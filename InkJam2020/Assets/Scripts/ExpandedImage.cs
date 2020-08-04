using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ExpandedImage : MonoBehaviour
       , IPointerClickHandler
{
    [SerializeField]
    private RawImage image;
    [SerializeField]
    private Text desc;

    public void Open(Texture newText, string newDesc)
    {
        gameObject.SetActive(true);
        image.texture = newText;
        desc.text = newDesc;
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Close();
    }
}
