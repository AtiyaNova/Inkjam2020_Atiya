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

    private void Start()
    {
        orig = icon.color;
        highlight = new Color(0.6f, 0.6f, 0.6f, 0.5f);
    }

    public void SetImages(Texture img1, Texture img2)
    {
        thumbnail = img1;
        full = img2;
        icon.texture = thumbnail;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        AppScreen.instance.ExpandImage(full);
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
