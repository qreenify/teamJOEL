using Model;
using UnityEngine;


namespace Control
{
    public class MergeHandler : MonoBehaviour
    {
        private MergeInventory mergeInventory;
        private void Start() {
            mergeInventory = FindObjectOfType<MergeInventory>();
        }

        public void MergeRunes() {
            if (mergeInventory.ListCount > 1) {
                mergeInventory.Merge();
                mergeInventory.ClearList();
                
            }
            else
            {
                Debug.Log("You need at least 2 runes to merge.");
            }
        }
    }
}

