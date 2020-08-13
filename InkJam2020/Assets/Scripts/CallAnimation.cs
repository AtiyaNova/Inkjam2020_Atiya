using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Just handles whatever sfx I'll go with for the calling
public class CallAnimation : MonoBehaviour
{
    [SerializeField]
    private RawImage[] ellipses;
    private int chosenWitch = 0;
    private float fadeTime = 0.6f;

    //Singleton
    public static CallAnimation instance;
    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        gameObject.SetActive(false);
        for (int i = 0; i < ellipses.Length; i++)
        {
            ellipses[i].color = Color.clear;
        }
    }

    public void StartCall(int num)
    {
        gameObject.SetActive(true);
        chosenWitch = num;
        StartCoroutine(BeginCallAnimation());
    }

    //forgive me for the hacky approach
    private IEnumerator BeginCallAnimation()
    {
        for (int i = 0; i < ellipses.Length; i++)
        {
            for (float t = 0.01f; t < fadeTime; t += Time.deltaTime)
            {
                ellipses[i].color = Color.Lerp(Color.clear, Color.white, Mathf.Min(1, t / fadeTime));
                yield return null;
            }
        }

        for (int i = 0; i < ellipses.Length; i++)
        {
            for (float t = 0.01f; t < fadeTime; t += Time.deltaTime)
            {
                ellipses[i].color = Color.Lerp(Color.white, Color.clear, Mathf.Min(1, t / fadeTime));
                yield return null;
            }
        }
        
        //then it switches to the story
        PhoneGeneral.instance.SwitchToStory();
        StoryManager.instance.PickWitch(chosenWitch);
        gameObject.SetActive(false);
    }

}

