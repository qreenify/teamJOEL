
using Model;
using UnityEngine;

public class RuneIdentifier : MonoBehaviour
{
    private bool isActive;
    private RuneColor colorId;
    private Rarity rarityId;

    public RuneColor ColorId
    {
        get => colorId;
        set => colorId = value;
    }

    public Rarity RarityId
    {
        get => rarityId;
        set => rarityId = value;
    }

    public bool IsActive
    {
        get => isActive;
        set => isActive = value;
    }
}
