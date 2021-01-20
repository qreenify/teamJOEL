using Model;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Control{
    public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
    {
        private RectTransform rectTransform;
        private CanvasGroup canvasGroup;

        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
            canvasGroup = GetComponent<CanvasGroup>();
        }
    
    
        public void OnDrag(PointerEventData eventData)
        {
            if (!this.gameObject.GetComponent<RuneIdentifier>().IsActive)
                return;
            rectTransform.anchoredPosition += eventData.delta;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (!this.gameObject.GetComponent<RuneIdentifier>().IsActive)
                return;
            var clone = Instantiate(gameObject, GetComponentInParent<RuneHandler>().gameObject.transform, true);
            clone.GetComponent<RuneIdentifier>().IsActive = true;
            clone.GetComponent<RuneIdentifier>().ColorId = gameObject.GetComponent<RuneIdentifier>().ColorId;
            clone.GetComponent<RuneIdentifier>().RarityId = gameObject.GetComponent<RuneIdentifier>().RarityId;
            clone.GetComponentInChildren<Text>().text = "1";
            eventData.pointerDrag = clone.gameObject;
            rectTransform = clone.GetComponent<RectTransform>();
            canvasGroup = clone.GetComponent<CanvasGroup>();
            canvasGroup.blocksRaycasts = false;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (!this.gameObject.GetComponent<RuneIdentifier>().IsActive)
                return;
            GetComponent<RuneIdentifier>().IsActive = false;
            canvasGroup.blocksRaycasts = true;
            Destroy(this.gameObject);
        }

        public void OnDrop(PointerEventData eventData)
        {
        }
    }
}
