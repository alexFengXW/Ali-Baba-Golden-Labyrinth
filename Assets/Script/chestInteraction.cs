using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    private void OnMouseDown()
    {
        InventoryManager.Instance.ToggleInventory();  // Toggle the visibility of the inventory
    }
}
