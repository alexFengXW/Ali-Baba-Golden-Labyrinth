
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;  // Singleton instance
    public GameObject inventoryPanel;  // Reference to the inventory panel

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        inventoryPanel.SetActive(false);  // Ensure inventory is hidden on start
    }

    public void ToggleInventory()
    {
        inventoryPanel.SetActive(!inventoryPanel.activeSelf);  // Toggle the visibility
    }
}
