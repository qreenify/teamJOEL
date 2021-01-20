using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class MergeInventory:MonoBehaviour{
        [SerializeField] private List<Rune> MergeList;
        public int listCapacity = 4;
        public RandomRune RandomRune;

        
        //event for adding a new Rune
        public event EventHandler<GameObject> MergeRuneAdded;
        
        public bool CanAddToList => MergeList.Count !< listCapacity;
        public int ListCount => MergeList.Count;

        public void ClearList(){
            MergeList.Clear();
        }
        private void Start(){
            MergeList = new List<Rune>();
            MergeList.Capacity = listCapacity;
            RandomRune = FindObjectOfType<RandomRune>();
        }
        
        public void AddRune(GameObject newGO) {
            Rune newRune = new Rune();
            newRune.color = newGO.GetComponent<RuneIdentifier>().ColorId;
            newRune.rarity = newGO.GetComponent<RuneIdentifier>().RarityId;
            MergeList.Add(newRune);
            
            //invoke event for adding to merge list
            OnMergeRuneAdded(newGO);
            Debug.Log($"Added: {newRune.color} {newRune.rarity} to {MergeList.Count}");
        }

        public void Merge() {
            Debug.Log("Merging Runes...");
            RandomRune.RandomRunes(this);
        }

        public void AddToMergeSlot(RuneType newRune)
        {
            //TODO set scale??
            Debug.Log(newRune + " in Merge slot.");
        }
        
        private void OnMergeRuneAdded(GameObject rune)
        {
            EventHandler<GameObject> handler = MergeRuneAdded;
            handler?.Invoke(this, rune);
        }

    }
}