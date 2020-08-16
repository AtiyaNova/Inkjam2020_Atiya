using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

//controls all the story instances
//switches from the phone to the story
public class StoryManager : MonoBehaviour
{
    public TextAsset inkJSON;
    private Story story;

    [SerializeField]
    private Text storyText, dayTest;

    [SerializeField] //ui specific
    private GameObject phoneLocked, gameplayCover, btnContinue, swipeToUnlock;
    [SerializeField] //story specific
    private GameObject poltergeist;

    [SerializeField]
    private GameObject[] speechChoices;

    [SerializeField]
    private RawImage character, scenery, timeOfDay, message;
    [SerializeField]
    private Texture[] times; //daytime is 0, nighttime is 1
    [SerializeField]
    private Texture[] diana, babaYaga, gryla, pesta;

    [SerializeField]
    private Texture[] sceneries;

    //Singleton
    public static StoryManager instance;

    private int witchAmount = 4, witchChoice, storyChoice = 0;
    private int[] correctChoices = {1,0,3,2};
    private List<int> playerChoices;
    private float fadeTime = 0.1f;
    private Color origCharColor;

    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        story = new Story(inkJSON.text);
        story.BindExternalFunction("SetCharacter", (bool active) =>
            {
                SetCharacter(active);
            });

        story.BindExternalFunction("ChangeScenery", (int index) =>
        {
            ChangeScenery(index);
        });

        story.BindExternalFunction("DisplayMessage", () =>
        {
            DisplayTextMessage();
        });


        story.BindExternalFunction("ProgressDay", (int num) =>
        {
            ProgressDay(num);
        });


        story.BindExternalFunction("SetTime", (int index) =>
        {
            SetTime(index);
        });

        story.BindExternalFunction("ActivatePoltergeist", (bool temp) =>
        {
            ActivatePoltergeist(temp);
        });

        story.BindExternalFunction("SetWitchExpression", (int index) =>
        {
            SetWitchExpression(index);
        });


        for (int i = 0; i < speechChoices.Length; i++) speechChoices[i].SetActive(false);
        poltergeist.SetActive(false);
        LockPhone(true);
        ContinueStory();

        //for aesthetics
        origCharColor = character.color;
        character.color = Color.clear;
        playerChoices = new List<int>();
    }


    //this is just for exiting the game
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
    }

    public void ContinueStory()
    {
        if (story.canContinue) storyText.text = story.Continue();
        else
        {
            if (story.currentChoices.Count == witchAmount)
            {
                LockPhone(false);
            }
            else if (story.currentChoices.Count == 3)
            {
                 CalculateStoryChoice();
            }
            else if (story.currentChoices.Count == 2)
            {
                ShowSpeechChoice();
            }
        }
    }

    public void ShowSpeechChoice()
    {
        for (int i = 0; i < speechChoices.Length; i++)
        {
            speechChoices[i].SetActive(true);
            speechChoices[i].GetComponentInChildren<Text>().text = story.currentChoices[i].text;
        }
    }

    public void LockPhone(bool temp)
    {
        phoneLocked.SetActive(temp);
        btnContinue.SetActive(temp);
        swipeToUnlock.SetActive(!temp);
        gameplayCover.SetActive(!temp);
    }

    public void PickWitch(int choice)
    {
        story.ChooseChoiceIndex(choice);
        character.gameObject.SetActive(true);
        witchChoice = choice;
        character.texture = GetCharacterTexture(witchChoice, 0);
        playerChoices.Add(choice);
        LockPhone(true);
        ContinueStory();
    }

    public void PickDialogue(int choice)
    {
        story.ChooseChoiceIndex(choice);
        for (int i = 0; i < speechChoices.Length; i++)
        {
            speechChoices[i].SetActive(false);
        }
        ContinueStory();

    }

    private void SetCharacter(bool temp)
    {
        if (temp && !CharacterFadedIn())
        {
            StartCoroutine(FadeInCharacter());
        }
        else if (!temp && CharacterFadedIn())
        {
            StartCoroutine(FadeOutCharacter());

        }
    }

    private Texture GetCharacterTexture(int choice, int expression)
    {
        switch (choice)
        {
            case 0:
                return diana[expression];
            case 1:
                return babaYaga[expression];
            case 2:
                return gryla[expression];

            default:
                return pesta[expression];
                
        }
    }

    private IEnumerator FadeInCharacter()
    {
        for (float t = 0.01f; t < fadeTime; t += Time.deltaTime)
        {
            character.color = Color.Lerp(Color.clear, origCharColor, Mathf.Min(1, t / fadeTime));
            yield return null;
        }
        character.color = origCharColor;
    }

    private IEnumerator FadeOutCharacter()
    {
        for (float t = 0.01f; t < fadeTime; t += Time.deltaTime)
        {
            character.color = Color.Lerp(origCharColor, Color.clear, Mathf.Min(1, t / fadeTime));
            yield return null;
        }
        character.color = Color.clear;
    }

    private bool CharacterFadedIn()
    {
        return character.color == origCharColor ? true : false;
    }

    private void ChangeScenery(int i)
    {
        print("it gets called");
        scenery.texture = sceneries[i];
    }

    private void CalculateStoryChoice()
    {
        int wrongChoices = 0;

        for (int i = 0; i < correctChoices.Length; i++)
        {
            if (playerChoices[i] != correctChoices[i])
            {
                wrongChoices++;
            }
        }

        if (wrongChoices >= 4) storyChoice = 2; //worst ending
        else if (wrongChoices > 0) storyChoice = 1; //mixed ending\

        CalculateEnding();
    }

    private void CalculateEnding()
    {
        story.ChooseChoiceIndex(storyChoice);
        ContinueStory();
    }

    private void ActivatePoltergeist(bool temp)
    {
        scenery.texture = sceneries[0];
        poltergeist.SetActive(temp);
    }

    private void SetTime(int index)
    {
        timeOfDay.texture = times[index];
    }

    private void ProgressDay(int num)
    {
        dayTest.text = "DAY " + num;
    }

    private void SetWitchExpression(int expression)
    {
        character.texture = GetCharacterTexture(witchChoice, expression);
    }

    private void DisplayTextMessage()
    {
        SoundManager.instance.PlayTextMsg();
        StartCoroutine(DisplayText());
    }

    //make this cleaner
    private IEnumerator DisplayText()
    {
        message.gameObject.SetActive(true);
        SoundManager.instance.PlayTextMsg();
        float msgTimer = 0, maxAmount = 3;

        while (msgTimer < maxAmount)
        {
            msgTimer += Time.deltaTime;
            yield return null;
        }

        message.gameObject.SetActive(false);
    }
}
