using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//Logic for calling the witch
public class CallWitch : MonoBehaviour
    , IPointerClickHandler
    , IPointerEnterHandler
    , IPointerExitHandler
{
    private RawImage sourceImg;
    private Color orig, highlight;
    private void Start()
    {
        sourceImg = GetComponent<RawImage>();

        orig = sourceImg.color;
        highlight = new Color(1f, 1f, 1f, 0.5f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        AppScreen.instance.ConfirmCall(); 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        sourceImg.color = highlight;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        sourceImg.color = orig;
    }
}
