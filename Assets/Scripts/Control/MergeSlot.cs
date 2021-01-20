using System;
using Model;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Control
{
    public class MergeSlot : MonoBehaviour, IDropHandler{
        private MergeInventory _mergeInventory;


        private void Start(){
            _mergeInventory = FindObjectOfType<MergeInventory>();
        }

        public void OnDrop(PointerEventData eventData)
        {
            Debug.Log("enter on drop");
            if (eventData.pointerDrag != null)
            {
                if (!_mergeInventory.CanAddToList)
                    return;
                /*var currentSprite = GetComponent<Image>();
                Debug.Log(currentSprite);
                var newSprite = eventData.pointerDrag.GetComponent<Transform>().GetComponent<Image>().sprite;
                Debug.Log(newSprite);
                currentSprite.overrideSprite = newSprite;
                Debug.Log(GetComponent<RectTransform>().position);*/
                
                Rune newRune = new Rune();
                newRune.color = eventData.pointerDrag.GetComponent<RuneIdentifier>().ColorId;
                newRune.rarity = eventData.pointerDrag.GetComponent<RuneIdentifier>().RarityId;
                _mergeInventory.AddRune(newRune);
            }
        }
    }
}
