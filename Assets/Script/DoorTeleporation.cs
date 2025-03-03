using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTeleporter : MonoBehaviour
{
    public string targetScene; // The name of the scene to load

    private void OnTriggerEnter(Collider other)
    {
         Debug.Log("Trigger entered by: " + other.name); // Check if the trigger is being hit
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(targetScene, LoadSceneMode.Single);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        PositionPlayerInNewScene();
    }

    void PositionPlayerInNewScene()
    {
        GameObject spawnPoint = GameObject.Find("SpawnPoint");
        if (spawnPoint != null)
        {
            Vector3 spawnPosition = spawnPoint.transform.position + spawnPoint.GetComponent<SpawnPoint>().offset;
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = spawnPosition;
        }
    }
}
