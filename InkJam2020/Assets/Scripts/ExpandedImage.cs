using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ExpandedImage : MonoBehaviour
       , IPointerClickHandler
{
    [SerializeField]
    private RawImage image, icon;
    [SerializeField]
    private Text desc, witchName, time;

    public void Open(GalleryIcon galleryIcon)
    {
        gameObject.SetActive(true);
        image.texture = galleryIcon.full;
        desc.text = galleryIcon.desc;
        witchName.text = galleryIcon.gName;
        time.text = galleryIcon.time;
        icon.texture = galleryIcon.fullIcon;
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
