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

    public void TravelToProfile()
    {
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
        PhoneGeneral.instance.SwitchToStory();
    }

    public void ExpandImage(Texture image)
    {
        expandImage.Open(image);
    }

}
