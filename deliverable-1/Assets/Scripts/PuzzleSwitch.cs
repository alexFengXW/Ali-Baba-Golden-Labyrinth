using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSwitch : MonoBehaviour
{
    public GameObject targetObject; // Assign object to activate (e.g., a door)

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetObject.SetActive(false); // Unlocks door when player steps on switch
            Debug.Log("Switch Activated!");
        }
    }
}
