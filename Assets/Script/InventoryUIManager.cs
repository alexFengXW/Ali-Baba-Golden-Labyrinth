using UnityEngine;

public class InventoryUIManager : MonoBehaviour
{
    public GameObject inventoryPanel; // Assign this in the inspector
    public PlayerControls playerControls; // Reference to the PlayerControls script

    private void Start()
    {
        inventoryPanel.SetActive(false); // Ensure the panel is hidden on start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) // Use 'T' to toggle inventory
        {
            ToggleInventory();
        }
    }

    private void ToggleInventory()
    {
        inventoryPanel.SetActive(!inventoryPanel.activeSelf); // Toggle the visibility of the inventory panel

        // Check for a null reference to prevent runtime errors
        if (playerControls != null)
        {
            // Toggle player controls based on the inventory's visibility
            playerControls.controlsEnabled = !inventoryPanel.activeSelf;
        }

        Debug.Log("Inventory panel active state: " + inventoryPanel.activeSelf);
    }
}
