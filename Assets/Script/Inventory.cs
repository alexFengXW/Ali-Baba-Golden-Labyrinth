using UnityEngine;
using System.Collections.Generic;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>(); // List to store inventory items

    // Method to add an item to the inventory
    public void AddItem(Item item)
    {
        // Check if the item already exists in the inventory
        if (!items.Contains(item))
        {
            items.Add(item);
            Debug.Log("Added item: " + item.itemName);
        }
        else
        {
            Debug.Log("Item already exists in the inventory: " + item.itemName);
        }

        UpdateInventoryUI(); 
    }

    public void RemoveItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log("Removed item: " + item.itemName);
        }

        UpdateInventoryUI();  // Update the UI every time an item is removed
    }

    // Method to update the inventory UI
    private void UpdateInventoryUI()
    {
        // This function would refresh the UI elements based on the current items in the inventory
        Debug.Log("Inventory updated. Current item count: " + items.Count);
    }
}
