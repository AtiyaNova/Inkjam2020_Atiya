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
    private GameObject phoneLocked;

    //Singleton
    public static StoryManager instance;

    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        story = new Story(inkJSON.text);
        ContinueStory();
    }

    public void ContinueStory()
    {
        if (story.canContinue) storyText.text = story.Continue();
        else LockPhone(false);
    }

    public void LockPhone(bool temp)
    {
        phoneLocked.SetActive(temp);
    }

    public void PickWitch(int choice)
    {
        story.ChooseChoiceIndex(choice);
        ContinueStory();
    }

    private void CalculateEnding()
    {

    }
}
