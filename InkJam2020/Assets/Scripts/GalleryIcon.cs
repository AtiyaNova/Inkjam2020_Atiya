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
    private RawImage icon;
    private Color orig, highlight;

    private void Start()
    {
        icon = GetComponent<RawImage>();
        icon.texture = thumbnail;

        orig = icon.color;
        highlight = new Color(1f, 1f, 1f, 0.8f);
    }

    public void SetImages(Texture img1, Texture img2)
    {
        thumbnail = img1;
        full = img2;
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
