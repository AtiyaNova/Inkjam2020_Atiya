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
    private Text storyText;

    [SerializeField] //ui specific
    private GameObject phoneLocked, gameplayCover, btnContinue, swipeToUnlock;
    [SerializeField] //story specific
    private GameObject poltergeist;

    [SerializeField]
    private GameObject[] speechChoices;

    [SerializeField]
    private RawImage character, scenery, timeOfDay;
    [SerializeField]
    private Texture[] characters, times; //daytime is 0, nighttime is 1

    [SerializeField]
    private Texture[] sceneries;

    //Singleton
    public static StoryManager instance;

    private int witchAmount = 3;
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

        story.BindExternalFunction("CalculateEndering", () =>
        {
            CalculateEnding();
        });

        story.BindExternalFunction("SetTime", (int index) =>
        {
            SetTime(index);
        });

        story.BindExternalFunction("ActivatePoltergeist", (bool temp) =>
        {
            ActivatePoltergeist(temp);
        });


        for (int i = 0; i < speechChoices.Length; i++) speechChoices[i].SetActive(false);
        poltergeist.SetActive(false);
        LockPhone(true);
        ContinueStory();

        //for aesthetics
        origCharColor = character.color;
        character.color = Color.clear;

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
            if (story.currentChoices.Count >= witchAmount)
                LockPhone(false);
            else if (story.currentChoices.Count > 0)
                ShowSpeechChoice();
        }
    }

    public void ShowSpeechChoice()
    {
        print(story.currentChoices.Count);
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
        character.texture = characters[choice];
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
        scenery.texture = sceneries[i];
    }

    private void CalculateEnding()
    {

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
}
