using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform target;

    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private float spawnTimer = 3f;

    void Update()
    {
        
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0 )
        {
            Enemy enemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            enemy.target = target;
            spawnTimer = 3f;
        }
    }
}
