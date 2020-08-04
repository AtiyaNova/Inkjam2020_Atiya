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
    [SerializeField]
    private Texture thumbnail, full;
    public RawImage icon;
    private Color orig, highlight;
    private int index = 0;
    private string desc;

    private void Start()
    {
        orig = icon.color;
        highlight = new Color(0.6f, 0.6f, 0.6f, 0.5f);
    }

    public void SetIndex(int i)
    {
        index = i;
    }

    public void SetImages(Texture img1, Texture img2, string desc2)
    {
        thumbnail = img1;
        full = img2;
        icon.texture = thumbnail;
        desc = desc2;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        AppScreen.instance.ExpandImage(full, desc);
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
