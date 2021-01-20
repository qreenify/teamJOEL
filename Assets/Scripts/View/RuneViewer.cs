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
        }


        private static void UpdateRuneCount(object sender, RuneType runeType){
            Debug.Log("In event callback method\n rune updated count: " + runeType.count + "\n rune color: " + runeType.rune.color);
        }
        
        private void AddRune(object sender, RuneType runeType)
        {
            ShowRuneInventory(runeType);
            Debug.Log("In event callback method\n new rune added with color: " + runeType.rune.color);
        }

        private void ShowRuneInventory(RuneType runeType)
        {
            string color = runeType.rune.color.ToString();
            ColorUtility.TryParseHtmlString (color, out Color myColor);
            runeTransformList[(int) runeType.rune.color * 5].GetComponent<Image>().color = myColor;
            runeTransformList[(int) runeType.rune.color * 5].GetComponent<Highlight>().DefaultColor = myColor;
            runeTransformList[(int) runeType.rune.color * 5].GetComponent<Highlight>().EnableHighlight();
        }
        
    }
}
