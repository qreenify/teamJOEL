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

        public void MergeRunes() {
            if (mergeInventory.ListCount > 1) {
                mergeInventory.ClearList();
                mergeInventory.Merge();
            }
            else
            {
                Debug.Log("You need at least 2 runes to merge.");
            }
        }
    }
}

