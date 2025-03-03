using UnityEngine;

public class InventoryUIManager : MonoBehaviour
{
    public GameObject inventoryPanel; // Assign this in the inspector

    private void Start()
    {
        inventoryPanel.SetActive(false); // Ensure the panel is hidden on start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleInventory();
        }
    }

    private void ToggleInventory()
    {
   
        inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        Debug.Log("Inventory panel active state: " + inventoryPanel.activeSelf);
    }

}
