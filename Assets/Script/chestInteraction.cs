using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    private void OnMouseDown()
    {
        InventoryManager.Instance.ToggleInventory(); 
    }
}
