using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//will be used to store the relevant series of images, along with the story data
[CreateAssetMenu(fileName = "New Witch", menuName = "Witch", order = 51)]
public class Witch : ScriptableObject
{
    [SerializeField]
    private string witchName, pfDesc, pTime;

    [SerializeField]
    private Texture pfp;

    [SerializeField]
    private int choiceNum;

    [SerializeField]
    private Texture[] thumbnails, expanded;

    [SerializeField]
    private string[] galleryDesc;

    //Getters
    public Texture GetPfp()
    {
        return pfp;
    }

    public string GetName()
    {
        return witchName;
    }

    public string GetPostTime()
    {
        return pTime;
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

    public string GetGalleryDesc(int i)
    {
        return galleryDesc[i];
    }
}
