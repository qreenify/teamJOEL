using System;
using Model;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Control
{
    public class MergeHandler : MonoBehaviour
    {
        public MergeInventory mergeInventory;
        
        private void Start() {
            mergeInventory = FindObjectOfType<MergeInventory>();
        }

        public void AddToMergeList(){
            var newRune = new RuneType{
                rune =
                    new Rune{rarity = Rarity.common, position = Vector2.down, color = (RuneColor) Random.Range(0, 3)},
                isMergable = true };
            if (mergeInventory.CanAddToList) { 
                mergeInventory.AddRune(newRune);
            }else {
                Debug.Log("Merge list is full.");
            }
        }

        public void MergeRunes() {
            var newRune = new RuneType();
            
            foreach (var rune in mergeInventory.MergeList)
            {
                if(!rune.isMergable)
                    return;
            }
            if (mergeInventory.MergeList.Count > 1) {
                if (mergeInventory.MergeList.Count == 2) {
                    mergeInventory.MergeList.Clear();
                    Debug.Log(mergeInventory.MergeList.Count);
                    mergeInventory.AddToMergeSlot(newRune);
                } 
                else if (mergeInventory.MergeList.Count == 3) {
                    mergeInventory.MergeList.Clear();
                    mergeInventory.AddToMergeSlot(newRune);
                } 
                else if (mergeInventory.MergeList.Count == 4) {
                    mergeInventory.MergeList.Clear();
                    mergeInventory.AddToMergeSlot(newRune);
                }
            }
            else
            {
                Debug.Log("You need at least 2 runes to merge.");
            }
        }
    }
}

