using UnityEngine;
using Random = UnityEngine.Random;

namespace Model
{
    public class RandomRune : MonoBehaviour
    {
        private MergeInventory mergeInventory;

        public int[] mergeTable1 = {
            800, //80 % chance to drop or same rarity
            200  //20 % chance to drop upgrade
        };
        
        public int[] mergeTable2 = {
            550,//55 % chance to drop upgrade
            450 //45 % chance to drop or same rarity
        };
        
        public int[] mergeTable3 = {
            950,  //95 % chance to drop upgrade
            50    //20 % chance to drop or same rarity
        };
        
        private void Start() {
            mergeInventory = FindObjectOfType<MergeInventory>();
            Randomizer(mergeTable1);
        }

        //TODO setup needs to be updated
        public void RandomRunes() {
            
            
            if (mergeInventory.ListCount == 2) {
                Randomizer(mergeTable1);
            } else if(mergeInventory.ListCount== 3) {
                Randomizer(mergeTable2);
            } else if (mergeInventory.ListCount == 4) {
                Randomizer(mergeTable3);
            }
            
            
            
        }

        public int total;
        public int randomNumber;

        public void Randomizer(int[] mergeTable) {
            foreach (var values in mergeTable) {
                total += values;
            }
            Debug.Log("Total value: " + total);

            randomNumber = Random.Range(0, total);
            Debug.Log("Random number: " + randomNumber);
            

            foreach (var chance in mergeTable) {
                if (randomNumber <= chance) {
                    //var newRune = new RuneType();
                    Debug.Log("New rune is: " + chance);
                }else {
                    randomNumber -= chance;
                }
            }
        }
    }
}