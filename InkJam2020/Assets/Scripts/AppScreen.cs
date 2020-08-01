using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppScreen : MonoBehaviour
{
    //The pages
    [SerializeField]
    GameObject mainScreen, profileScreen;

    //Singleton
    public static AppScreen instance;

    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        mainScreen.SetActive(true);
        profileScreen.SetActive(false);
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

    }

    public void CancelCall()
    {

    }

    public void Call()
    {

    }

    public void ExpandImage()
    {

    }

    public void CloseImage()
    {

    }
}
