using System;
using Model;
using UnityEngine;

namespace View{
    public class RuneViewer : MonoBehaviour{
        private RuneInventory _runeInventory;

        private void Start(){
            _runeInventory = FindObjectOfType<RuneInventory>();
            _runeInventory.RuneCountUpdated += UpdateRuneCount;
        }


        private static void UpdateRuneCount(object sender, RuneType runeType)
        {
            Debug.Log("In event callback method\n rune updated count: " + runeType.count + "\n rune color: " + runeType.rune.color);
   }
    }
}
