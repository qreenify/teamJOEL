using System.Collections.Generic;
using UnityEngine;
using View;

namespace Model
{
    public class MergeInventory:MonoBehaviour {
        public List<RuneType> MergeList { get; set; }
        public int listCapacity = 4;
        public MergeSlot MergeSlot;
        public RandomRune RandomRune;

        public bool CanAddToList => MergeList.Count !< listCapacity;
        
        private void Start(){
            MergeList = new List<RuneType>();
            MergeList.Capacity = listCapacity;
            MergeSlot = FindObjectOfType<MergeSlot>();
            RandomRune = FindObjectOfType<RandomRune>();
        }
        
        public void AddRune(RuneType newRune) {
            MergeList.Add(newRune);
            Debug.Log($"Added: {newRune.rune.color} {newRune.rune.rarity} to {MergeList.Count}");
        }

        public void Merge() {
            Debug.Log("Merging Runes...");
            RandomRune.RandomRunes(this);
        }

        public void AddToMergeSlot(RuneType newRune)
        {
            newRune.rune.position = MergeSlot.transform.position;
            //TODO set scale??
            Debug.Log(newRune + " in Merge slot.");
        }
    }
}