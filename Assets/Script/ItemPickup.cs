using UnityEngine;
using static UnityEditor.Progress;

public class ItemPickup : MonoBehaviour
{
    public Item item; // The item data to be picked up

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory playerInventory = other.GetComponent<Inventory>();
            if (playerInventory)
            {
                playerInventory.AddItem(item);
                gameObject.SetActive(false); // Deactivate the item after pickup
                Debug.Log("Item picked up: " + item.itemName);
            }
        }
    }
}
