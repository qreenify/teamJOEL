using System;
using System.Collections;
using System.Collections.Generic;
using Control;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private GameObject clone;

    private bool move;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    
    
    public void OnDrag(PointerEventData eventData)
    {
        if (clone == null)
            return;
        //rectTransform.anchoredPosition += eventData.delta;

        //Debug.Log("in onpointerdown: " + eventData + "position" + rectTransform.anchoredPosition);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!this.gameObject.GetComponent<RuneIdentifier>().IsActive)
            return;
        clone = Instantiate(gameObject);
        clone.transform.SetParent(GetComponentInParent<RuneHandler>().gameObject.transform);
        rectTransform = clone.GetComponent<RectTransform>();
        canvasGroup = clone.GetComponent<CanvasGroup>();
        rectTransform.anchoredPosition = Input.mousePosition;
        
        eventData.pointerDrag = clone;
        canvasGroup.blocksRaycasts = false;

        move = true;
    }//bryt

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        //move = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        
    }

    private void Update()
    {
        if (move)
        {
            rectTransform.anchoredPosition = Input.mousePosition;
        }
        
    }
}
