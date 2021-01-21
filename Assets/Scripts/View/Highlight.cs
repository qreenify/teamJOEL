using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace View{
    public class Highlight : MonoBehaviour, IPointerEnterHandler
    {
        public Color DefaultColor{ get; set; }
        public bool HighlightColor{ get; set; }
        private Image Image => GetComponent<Image>();

        private void Start(){
            DefaultColor = Image.color;
        }

        //-> Remove highlight when hovered
        public void OnPointerEnter(PointerEventData eventData)
        {
            Image.color = DefaultColor;
            HighlightColor = false;
        }

    
        //-> Highlight newly added runes
        public void EnableHighlight()
        {
            if (!HighlightColor){
                Image.color += new Color(0.5f, 0.5f, 0.5f);
                HighlightColor = true;
            }
            
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
}
