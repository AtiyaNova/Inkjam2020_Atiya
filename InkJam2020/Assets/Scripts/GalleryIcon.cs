using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GalleryIcon : MonoBehaviour
    , IPointerClickHandler
    , IPointerEnterHandler
    , IPointerExitHandler
{
    public Texture thumbnail, full, fullIcon;
    public RawImage icon;
    private Color orig, highlight;
    public int index = 0;
    public string desc, gName, time;

    private void Start()
    {
        orig = icon.color;
        highlight = new Color(0.6f, 0.6f, 0.6f, 0.5f);
    }

    public void SetIndex(int i)
    {
        index = i;
    }

    public void SetImages(Witch theWitch, int index)
    {
        thumbnail = theWitch.GetThumbnail(index);
        full = theWitch.GetExpanded(index);
        icon.texture = thumbnail;
        desc = theWitch.GetGalleryDesc(index);
        gName = theWitch.GetName();
        time = theWitch.GetPostTime();
        fullIcon = theWitch.GetPfp(); 
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        AppScreen.instance.ExpandImage(this);
        icon.color = orig;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        icon.color = highlight;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        icon.color = orig;
    }
}
