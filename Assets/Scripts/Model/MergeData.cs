using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class MergeData:MonoBehaviour {
        public List<RuneType> mergeList;

        private void Start(){
            mergeList = new List<RuneType>();
        }
    }
}