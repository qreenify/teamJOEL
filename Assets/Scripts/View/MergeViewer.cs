using Model;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class MergeViewer : MonoBehaviour{

    private MergeInventory _mergeInventory;
    [SerializeField] private Transform[] mergeArray;
    // Start is called before the first frame update
    private Color defaultColor;
    void Start(){
        _mergeInventory = FindObjectOfType<MergeInventory>();
        _mergeInventory.MergeRuneAdded += ShowMergeRune;
        defaultColor = mergeArray[0].GetComponent<Image>().color;
    }

    private void ShowMergeRune(object sender, GameObject e){
        foreach (var slot in mergeArray){
            if (slot.GetComponent<Image>().color != defaultColor)
                continue;
            slot.GetComponent<Image>().overrideSprite = e.GetComponent<Image>().sprite;
            slot.GetComponent<Image>().color = e.GetComponent<Image>().color;
            break;
        }
    }
}
