using System;
using Model;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Control
{
    public class MergeHandler : MonoBehaviour
    {
        public MergeInventory mergeInventory;
        public GameObject mergeSlot;
        
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
            foreach (var rune in mergeInventory.MergeList) {
                if(!rune.isMergable)
                    return;
            }
            if (mergeInventory.MergeList.Count > 1) {
                mergeInventory.MergeList.Clear();
                mergeInventory.Merge();
            }
            else
            {
                Debug.Log("You need at least 2 runes to merge.");
            }
        }
    }
}

