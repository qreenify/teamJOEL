using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropSlot : MonoBehaviour, IDropHandler
{

    public Transform prefab;
    
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("enter on drop");
        if (eventData.pointerDrag != null)
        {
            // Transform child = prefab.transform.GetChild(prefab.transform.childCount - 1);
            // Destroy(child.gameObject);
            // eventData.pointerDrag.GetComponent<Transform>().parent = prefab.transform;
            // eventData.pointerDrag.GetComponent<Transform>().SetSiblingIndex(0);
            var currentSprite = GetComponent<Image>();
            Debug.Log(currentSprite);
            var newSprite = eventData.pointerDrag.GetComponent<Transform>().GetComponent<Image>().sprite;
            Debug.Log(newSprite);
            currentSprite.overrideSprite = newSprite;
            Debug.Log(GetComponent<RectTransform>().position);
           
            
        }
    }
}
