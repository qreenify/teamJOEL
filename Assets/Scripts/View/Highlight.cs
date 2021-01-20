using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Highlight : MonoBehaviour, IPointerEnterHandler
{
    public Color DefaultColor{ get; set; }
    private Image Image => GetComponent<Image>();

    private void Start(){
        DefaultColor = Image.color;
    }

    //-> Remove highlight when hovered
    public void OnPointerEnter(PointerEventData eventData)
    {
        Image.color = DefaultColor;
    }

    
    //-> Highlight newly added runes
    public void EnableHighlight()
    {
        Image.color += new Color(0.5f, 0.5f, 0.5f);
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
