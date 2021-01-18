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
                
                var oldRune = inventory.RunesList.Find(i => i.rune.color == newRune.rune.color && i.rune.rarity == newRune.rune.rarity );
                if (oldRune != null){
                    oldRune.count++;
                }
                else{
                    newRune.count = 1;
                    inventory.RunesList.Add(newRune);
                }
            }
            Debug.Log("created 4 runes");
        } 
    }
}
