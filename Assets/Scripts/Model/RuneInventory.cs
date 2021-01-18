using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class RuneInventory: MonoBehaviour {
        private List<RuneType> runesList;

        private void Start(){
            runesList = new List<RuneType>();
        }
        
    }
}