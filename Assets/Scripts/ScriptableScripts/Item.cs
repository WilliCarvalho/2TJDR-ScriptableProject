using UnityEngine;

[CreateAssetMenu (fileName = "EquippedItem", menuName = "ScriptableAssets/New Item")]
public class Item : ScriptableObject
{
    [SerializeField] public GameObject itemPrefab;
    [SerializeField] public Sprite itemImage;
    [SerializeField] public int itemPrice;
    [SerializeField] public string itemName;
    [SerializeField] public EItemType itemType;
    [HideInInspector] public EItemState itemState;
}


public enum EItemType
{
    Helmet,
    Armor,
    Weapon
}

public enum EItemState
{
    ToSell,
    ToBuy,
    Equipped
}