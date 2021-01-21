using Model;
using UnityEngine;
using UnityEngine.UI;

namespace View{
    public class RuneViewer : MonoBehaviour{
        private RuneInventory _runeInventory;
        [SerializeField] private Transform[] runeTransformList;

        private void Start(){
            _runeInventory = FindObjectOfType<RuneInventory>();
            _runeInventory.RuneCountUpdated += UpdateRuneCount;
            _runeInventory.NewRuneAdded += AddRune;

            for (int i = 0; i < runeTransformList.Length; i++)
            {
                runeTransformList[i].GetComponent<RuneIdentifier>().ColorId = (RuneColor) (i/5) ;
                runeTransformList[i].GetComponent<RuneIdentifier>().RarityId = (Rarity) (i%5);
            }
        }

        private void UpdateRuneCount(object sender, RuneType runeType){
            Debug.Log("In event callback method\n rune updated count: " + runeType.count + "\n rune color: " + runeType.rune.color);
            UpdateRuneCountOwned(runeType);
        }
        
        private void AddRune(object sender, RuneType runeType)
        {
            ShowRuneInventory(runeType);
            UpdateRuneCountOwned(runeType);
        }
        
        private  void UpdateRuneCountOwned(RuneType runeType){
            runeTransformList[(int) runeType.rune.color * 5].GetComponentInChildren<Text>().text = runeType.count.ToString();
            runeTransformList[(int) runeType.rune.color * 5].GetComponent<Highlight>().EnableHighlight();
        }


        private void ShowRuneInventory(RuneType runeType)
        {
            string color = runeType.rune.color.ToString();
            ColorUtility.TryParseHtmlString (color, out Color myColor);
            runeTransformList[(int) runeType.rune.color * 5].GetComponent<Image>().color = myColor;
            runeTransformList[(int) runeType.rune.color * 5].GetComponent<Highlight>().DefaultColor = myColor;
            //runeTransformList[(int) runeType.rune.color * 5].GetComponent<Highlight>().EnableHighlight();
            runeTransformList[(int) runeType.rune.color * 5].GetComponent<RuneIdentifier>().IsActive = true;
        }
        
    }
}
