using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public string sceneName;  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LoadScene();  
        }
    }

    private void LoadScene()
    {
        Debug.Log("Loading Scene...");
        SceneManager.LoadScene(sceneName); // Load the specified scene
    }
}
