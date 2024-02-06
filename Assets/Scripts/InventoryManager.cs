using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<ShoppingItem> shop1Items;
    //public List<ShoppingItem> shop2Items;
    public GameObject itemPrefab;
    public Transform itemPrefabParent;
    // Start is called before the first frame update
    void Start()
    {
        DisplayInventory1();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DisplayInventory1()
    {
        for (int i = 0; i < shop1Items.Count; i++)
        {
            Instantiate(itemPrefab, itemPrefabParent);
        }
    }


    //public List<ShoppingItem> playerInventory = new List<ShoppingItem>();
    //public Transform itemPrefabParent;
    //public GameObject playerObjects;
    //public bool BuyItem(ShoppingItem item)
    //{
    //    if (CanAfford(item))
    //    {
    //        playerInventory.Add(item);
    //        return true;
    //    }
    //    return false;
    //}

    //public bool SellItem(ShoppingItem item)
    //{
    //    if (playerInventory.Contains(item))
    //    {
    //        playerInventory.Remove(item);
    //        return true;
    //    }
    //    return false;
    //}

    //bool CanAfford(ShoppingItem item)
    //{
    //    // Check if the player can afford the item
    //    // In a real game, you might want to have a player currency variable
    //    // and perform more complex checks
    //    return true;
    //}
    //public void DisplayInventory1()
    //{
    //    for (int i = 0; i < playerInventory.Count; i++)
    //    {
    //        Instantiate(playerObjects, itemPrefabParent);
    //    }
    //    //SetData();
    //}
    ////public void SetData()
    ////{
    ////    for (int i = 0; i < playerInventory.Count; i++)
    ////    {
    ////        playerObjects.itemPrice.text = playerInventory[i].cost.ToString();
    ////        playerObjects.itemImage.sprite = playerInventory[i].icon;
    ////    }
    ////}
}
