
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;  
    public GameObject inventoryPanel;  

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

        inventoryPanel.SetActive(false);  
    }

    public void ToggleInventory()
    {
        inventoryPanel.SetActive(!inventoryPanel.activeSelf); 
    }
}
