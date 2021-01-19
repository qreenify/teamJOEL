using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Highlight : MonoBehaviour, IPointerEnterHandler
{
    private Color defaultColor;
    Color highlightColor = Color.cyan;
    private Image image => GetComponent<Image>();

    private void Start()
    {
        defaultColor = image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = defaultColor;
    }

    public void EnableHighlight()
    {
        image.color = highlightColor;
    }

    private void Update()
    {
        //For testing
        if (Input.GetKey(KeyCode.H))
        {
            EnableHighlight();
        }
    }
}
