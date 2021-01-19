using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Highlight : MonoBehaviour, IPointerEnterHandler
{
    public GameObject highlightObject;
    //private bool highlightEnabled = false;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        highlightObject.SetActive(false);
    }

    public void EnableHighlight()
    {
        //highlightEnabled = !highlightEnabled;
        highlightObject.SetActive(true);
    }
}
