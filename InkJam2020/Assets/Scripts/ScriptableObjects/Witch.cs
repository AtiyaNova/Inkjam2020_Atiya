using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//will be used to store the relevant series of images, along with the story data
[CreateAssetMenu(fileName = "New Witch", menuName = "Witch", order = 51)]
public class Witch : ScriptableObject
{
    [SerializeField]
    private string witchName, pfDesc;

    [SerializeField]
    private Texture pfp;

    [SerializeField]
    private int choiceNum;

    [SerializeField]
    private Texture[] thumbnails, expanded;

    //Getters
    public Texture GetPfp()
    {
        return pfp;
    }

    public string GetName()
    {
        return witchName;
    }

    public string GetDescription()
    {
        return pfDesc;
    }

    public int GetChoice()
    {
        return choiceNum;
    }

    public Texture GetThumbnail(int i)
    {
        return thumbnails[i];
    }

    public Texture GetExpanded(int i)
    {
        return expanded[i];
    }
}
