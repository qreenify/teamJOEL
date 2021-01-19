using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class RuneInventory: MonoBehaviour {
        private List<RuneType> RunesList{ get; set; }
        
        //event for updating count of existing Rune
        public event EventHandler<RuneType> RuneCountUpdated;

        private void Start(){
            RunesList = new List<RuneType>();
        }

        public void AddRune(RuneType newRune) {

            var oldRune = RunesList.Find(i =>
                i.rune.color == newRune.rune.color && i.rune.rarity == newRune.rune.rarity);
            if (oldRune != null)
            {
                oldRune.count++;
                Debug.Log(oldRune.rune.color + " hej " + oldRune.count + " count updated");
                //Todo update count, number of runes, trigger event for update count
                OnRuneCountUpdated(oldRune);
            }
            else
            {
                newRune.count = 1;
                RunesList.Add(newRune);
                Debug.Log(newRune.rune.color + " new rune added");
                //Todo Add sprite for rune, trigger event for adding new sprite
            }
        }
        
        private void OnRuneCountUpdated(RuneType runeType)
        {
            EventHandler<RuneType> handler = RuneCountUpdated;
            handler?.Invoke(this, runeType);
        }
    }
}