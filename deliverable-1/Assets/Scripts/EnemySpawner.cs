using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Assign an enemy prefab in Unity Inspector
    public float spawnInterval = 5f; // Time between spawns
    public GameObject player;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, spawnInterval); // Spawns every 5 seconds
    }

    void SpawnEnemy()
    {

        Instantiate(enemyPrefab, new Vector3(player.transform.position.x + Random.Range(-2f, 2f), player.transform.position.y, player.transform.position.z + Random.Range(-2f, 2f)), Quaternion.identity);
    }
}
