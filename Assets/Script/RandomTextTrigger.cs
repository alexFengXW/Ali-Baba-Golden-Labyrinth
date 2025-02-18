using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomTextTrigger : MonoBehaviour
{
    public TextMeshPro displayText;
    public string[] messages;  


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int randomIndex = Random.Range(0, messages.Length);

            displayText.text = messages[randomIndex];
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            displayText.text = "";
        }
    }
}
