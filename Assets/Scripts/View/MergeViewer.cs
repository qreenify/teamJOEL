using Model;
using UnityEngine;
using UnityEngine.UI;

public class MergeViewer : MonoBehaviour{

    private MergeInventory _mergeInventory;
    [SerializeField] private Transform[] mergeArray;
    // Start is called before the first frame update
    void Start(){
        _mergeInventory = FindObjectOfType<MergeInventory>();
        _mergeInventory.MergeRuneAdded += ShowMergeRune;
    }

    private void ShowMergeRune(object sender, GameObject e){
        mergeArray[0].GetComponent<Image>().overrideSprite = e.GetComponent<Image>().sprite;
        mergeArray[0].GetComponent<Image>().color = e.GetComponent<Image>().color;
    }
}
