using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickApp : MonoBehaviour
         , IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        PhoneGeneral.instance.ChangeScreens(false, false, true);
    }
}
