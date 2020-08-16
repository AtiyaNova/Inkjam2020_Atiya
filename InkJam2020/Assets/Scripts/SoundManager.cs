using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource click, textMsg, ringtone, appClick;

    //Singleton
    public static SoundManager instance;

    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }

    public void PlayClick()
    {
        click.Play();
    }

    public void PlayTextMsg()
    {
        textMsg.Play();
    }

    public void PlayRingtone()
    {
        ringtone.Play();
    }

    public void PlayAppClick()
    {
        appClick.Play();
    }
}
