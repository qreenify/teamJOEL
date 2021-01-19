using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{

    public GameObject prefab;
    
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("enter on drop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(75, -50);
            Debug.Log(GetComponent<RectTransform>().position);
           
            
        }
    }
}
