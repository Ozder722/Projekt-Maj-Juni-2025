using NUnit.Framework;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public ContextMenuItemAttribute currentItem;
    public List<Item> items = new List<Item>();
    public int numberOfKeys;

}
