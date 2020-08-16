using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppScreen : MonoBehaviour
{
    //The pages
    [SerializeField]
    GameObject mainScreen, profileScreen, confirmCall;
    [SerializeField]
    ExpandedImage expandImage;
    [SerializeField]
    RawImage pfp;
    [SerializeField]
    Text description, name;
    [SerializeField]
    private GalleryIcon[] galleryIcons;

    //The Witch
    private Witch currentWitch;

    //Singleton
    public static AppScreen instance;

    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        OpenApp();
        expandImage.gameObject.SetActive(false);
        confirmCall.SetActive(false);
    }

    public void OpenApp()
    {
        mainScreen.SetActive(true);
        profileScreen.SetActive(false);
        confirmCall.SetActive(false);
        expandImage.Close();
        SoundManager.instance.PlayClick();
    }

    public void TravelToProfile(CardTemplate witch)
    {
        SoundManager.instance.PlayAppClick();
        currentWitch = witch.theWitch;
        pfp.texture = currentWitch.GetPfp();
        description.text = currentWitch.GetDescription();
        name.text = currentWitch.GetName();

        for (int i = 0; i < galleryIcons.Length; i++)
        {
            galleryIcons[i].SetImages(currentWitch,i);
        }

        mainScreen.SetActive(false);
        profileScreen.SetActive(true);
    }

    public void GoBack()
    {
        mainScreen.SetActive(true);
        profileScreen.SetActive(false);
        SoundManager.instance.PlayAppClick();
    }

    public void ConfirmCall()
    {
        confirmCall.SetActive(true);
        SoundManager.instance.PlayAppClick();
    }

    public void CancelCall()
    {
        confirmCall.SetActive(false);
        SoundManager.instance.PlayAppClick();
    }

    public void Call()
    {
        GoBack();
        CallAnimation.instance.StartCall(currentWitch.GetChoice());
    }

    public void ExpandImage(GalleryIcon theIcon)
    {
        expandImage.Open(theIcon);
    }

}
