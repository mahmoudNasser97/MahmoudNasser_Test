using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shopping Items", menuName = "Shopping/Item")]
public class ShoppingItem : ScriptableObject
{
    //public int itemID;
    public int cost;
    public int sellPrice;
    public Sprite icon;
}
