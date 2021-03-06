﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class RuneInventory: MonoBehaviour
    {

        [SerializeField] private List<RuneType> RunesList; 
        
        //event for updating count of existing Rune
        public event EventHandler<RuneType> RuneCountUpdated;

        //event for adding a new Rune
        public event EventHandler<RuneType> NewRuneAdded;

        private void Start(){
            RunesList = new List<RuneType>();
        }

        public void AddRune(RuneType newRune) {

            var oldRune = RunesList.Find(i =>
                i.rune.color == newRune.rune.color && i.rune.rarity == newRune.rune.rarity);
            if (oldRune != null)
            {
                oldRune.count++;
                
                //update count, number of runes, trigger event for update count
                OnRuneCountUpdated(oldRune);
            }
            else
            {
                newRune.count = 1;
                RunesList.Add(newRune);
                //Todo Add sprite for rune, trigger event for adding new sprite
                OnRuneAdded(newRune);
            }
        }
        
        private void OnRuneCountUpdated(RuneType runeType)
        {
            EventHandler<RuneType> handler = RuneCountUpdated;
            handler?.Invoke(this, runeType);
        }
        
        private void OnRuneAdded(RuneType runeType)
        {
            EventHandler<RuneType> handler = NewRuneAdded;
            handler?.Invoke(this, runeType);
        }
    }
}