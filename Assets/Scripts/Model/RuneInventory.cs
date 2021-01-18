using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class RuneInventory: MonoBehaviour {
        public List<RuneType> RunesList{ get; set; }

        private void Start(){
            RunesList = new List<RuneType>();
        }
        
    }
}