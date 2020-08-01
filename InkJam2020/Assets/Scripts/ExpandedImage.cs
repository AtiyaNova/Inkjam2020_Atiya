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

    public void Open(Texture newText)
    {
        gameObject.SetActive(true);
        image.texture = newText;
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
