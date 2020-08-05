using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneGeneral : MonoBehaviour
{
    [SerializeField]
    private GameObject lockScreen, homeScreen, appScreen;

    //Singleton
    public static PhoneGeneral instance;

    void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(gameObject); }
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeScreens(true, false, false);
    }

    public void ChangeScreens(bool lockS, bool homeS, bool appS)
    {
        lockScreen.SetActive(lockS);
        homeScreen.SetActive(homeS);
        appScreen.SetActive(appS);
    }

    public bool OnLockscreen()
    {
        return lockScreen.activeSelf;
    }

    public void SwitchToStory()
    {
        ChangeScreens(true, false, false);
    }

}
