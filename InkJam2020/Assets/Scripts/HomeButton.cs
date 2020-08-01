using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HomeButton : MonoBehaviour
      , IPointerClickHandler
      , IPointerEnterHandler
      , IPointerExitHandler
{
    [SerializeField]
    private RawImage homeButton;
    private Color orig, highlight;

    private void Start()
    {
        homeButton = GetComponent<RawImage>();
        orig = homeButton.color;
        highlight = new Color(1, 1, 1, 0.5f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!PhoneGeneral.instance.OnLockscreen())
        {
            PhoneGeneral.instance.ChangeScreens(false, true, false);
            AppScreen.instance.OpenApp();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        homeButton.color = highlight;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        homeButton.color = orig;
    }
}
