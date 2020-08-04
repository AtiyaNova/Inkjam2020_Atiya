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
    Text description;
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
    }

    public void TravelToProfile(CardTemplate witch)
    {
        currentWitch = witch.theWitch;
        pfp.texture = currentWitch.GetPfp();
        description.text = currentWitch.GetDescription();

        for (int i = 0; i < galleryIcons.Length; i++)
        {
            galleryIcons[i].SetImages(currentWitch.GetThumbnail(i), currentWitch.GetExpanded(i), currentWitch.GetGalleryDesc(i));
        }

        mainScreen.SetActive(false);
        profileScreen.SetActive(true);
    }

    public void GoBack()
    {
        mainScreen.SetActive(true);
        profileScreen.SetActive(false);
    }

    public void ConfirmCall()
    {
        confirmCall.SetActive(true);
    }

    public void CancelCall()
    {
        confirmCall.SetActive(false);
    }

    public void Call()
    {
        GoBack();
        PhoneGeneral.instance.SwitchToStory();
        StoryManager.instance.PickWitch(currentWitch.GetChoice());
    }

    public void ExpandImage(Texture image, string theText)
    {
        expandImage.Open(image, theText);
    }

}
