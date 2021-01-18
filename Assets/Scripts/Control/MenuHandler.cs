using UnityEngine;

public class MenuHandler : MonoBehaviour{
    [SerializeField ]private GameObject mainMenu;
    [SerializeField ]private GameObject runeMenu;
    
    public void showRuneHandler(){
        mainMenu.GetComponent<Canvas>().enabled = false;
        runeMenu.GetComponent<Canvas>().enabled = true;
    }
}
