using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardTemplate : MonoBehaviour
{
    public Witch theWitch;

    [SerializeField]
    private RawImage pfp;
    [SerializeField]
    private Text theName;

    private void Start()
    {
        pfp.texture = theWitch.GetPfp();
        theName.text = theWitch.GetName();
    }
}
