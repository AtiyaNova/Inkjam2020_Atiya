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

    [SerializeField]
    private GameObject phoneLocked, gameplayCover;
    [SerializeField]
    private GameObject[] speechChoices;

    [SerializeField]
    private RawImage character, scenery;
    [SerializeField]
    private Texture[] characters;

    [SerializeField]
    private Texture[] sceneries;

    //Singleton
    public static StoryManager instance;

    private int witchAmount = 3;

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

       

        for (int i = 0; i < speechChoices.Length; i++) speechChoices[i].SetActive(false);
        character.gameObject.SetActive(false);
        LockPhone(true);
        ContinueStory();
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
        character.gameObject.SetActive(temp);
    }

    private void ChangeScenery(int i)
    {
        scenery.texture = sceneries[i];
    }

    private void CalculateEnding()
    {

    }
}
