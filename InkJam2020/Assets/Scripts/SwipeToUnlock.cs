using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeToUnlock : MonoBehaviour
     , IDragHandler
     , IEndDragHandler
     , IBeginDragHandler

{
    private Vector2 initPos;
    [SerializeField]
    private float finalX;
    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        initPos = rectTransform.anchoredPosition;
    }

    //Will probably use this for visual fx
    public void OnBeginDrag(PointerEventData eventData)
    {
    }
    
    //swipe is kinda busted, needs to be fixed
    //Drags the swipe
    public void OnDrag(PointerEventData eventData)
    {
        
    }

    //Unlocks the screen
    public void OnEndDrag(PointerEventData eventData)
    {
        PhoneGeneral.instance.ChangeScreens(false, true, false);
    }

    private void ResetPosition()
    {
        rectTransform.anchoredPosition = initPos;
    }
}
