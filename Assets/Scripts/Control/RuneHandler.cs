using Model;
using UnityEngine;

namespace Control{
    public class RuneHandler : MonoBehaviour
    {
        public void PurchaseRandomRunes(){
            var inventory = FindObjectOfType<RuneInventory>();
            
            for (var i = 0; i < 4; i++){
                var newRune = new RuneType{
                    rune =
                        new Rune{rarity = Rarity.common, position = Vector2.down, color = (RuneColor) Random.Range(0, 3)},
                    isMergable = true
                };

                inventory.AddRune(newRune);
            }
            
        } 
    }
}






