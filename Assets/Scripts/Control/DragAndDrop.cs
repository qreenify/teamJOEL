using UnityEngine;
using UnityEngine.EventSystems;

namespace Control{
    public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
    {
        private RectTransform rectTransform;
        private CanvasGroup canvasGroup;

        private void Awake()
        {
            Debug.Log("Awake");
            rectTransform = GetComponent<RectTransform>();
            canvasGroup = GetComponent<CanvasGroup>();
        }
    
    
        public void OnDrag(PointerEventData eventData)
        {
            if (!this.gameObject.GetComponent<RuneIdentifier>().IsActive)
                return;
            rectTransform.anchoredPosition += eventData.delta;
            Debug.Log("OnDrag");
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("OnBeginDrag");
            if (!this.gameObject.GetComponent<RuneIdentifier>().IsActive)
                return;
            var clone = Instantiate(gameObject, GetComponentInParent<RuneHandler>().gameObject.transform, true);
            clone.GetComponent<RuneIdentifier>().IsActive = true;
            eventData.pointerDrag = clone.gameObject;
            rectTransform = clone.GetComponent<RectTransform>();
            canvasGroup = clone.GetComponent<CanvasGroup>();
            canvasGroup.blocksRaycasts = false;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("OnEndDrag");
            canvasGroup.blocksRaycasts = true;
        }

        public void OnDrop(PointerEventData eventData)
        {
            Debug.Log("OnDrop");
        }
    }
}
