using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class MergeInventory:MonoBehaviour {
        public List<RuneType> MergeList { get; set; }
        public int listCapacity = 4;

        public bool CanAddToList => MergeList.Count !< listCapacity;
        
        private void Start(){
            MergeList = new List<RuneType>();
            MergeList.Capacity = listCapacity;

        }
        
        public void AddRune(RuneType newRune) {
            MergeList.Add(newRune);
            Debug.Log($"Added: {newRune.rune.color} {newRune.rune.rarity} to {MergeList.Count}");
        }

        public void RemoveAllRunes() {
            foreach (var rune in MergeList)
            {
                MergeList.Remove(rune);
                Debug.Log("Removed" + rune);
            }
            
            Debug.Log("List contains " + MergeList.Count + " objects.");
        }

        public void Merge()
        {
            
        }

        public void AddToMergeSlot(RuneType newRune) {
            Debug.Log(newRune + " in Merge slot.");
        }
    }
}