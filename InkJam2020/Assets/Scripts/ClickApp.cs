using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickApp : MonoBehaviour
         , IPointerClickHandler
         , IPointerEnterHandler
         , IPointerExitHandler
{
    private RawImage appArt;
    private Color orig, highlight;

    private void Start()
    {
        appArt = GetComponent<RawImage>();
        orig = appArt.color;
        highlight = new Color(0.5f, 0.5f, 0.5f, 0.5f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PhoneGeneral.instance.ChangeScreens(false, false, true);
        appArt.color = orig;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        appArt.color = highlight;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        appArt.color = orig;
    }
}
