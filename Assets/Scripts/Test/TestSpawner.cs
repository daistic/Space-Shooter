using UnityEngine;

public class TestSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] float spawnDelay;
    [SerializeField, Range(0f, 1f)] float spawnNoiseOffset;
    [SerializeField, Range(0f, 1f)] float typeNoiseOffset;

    private float spawnTime = 0f;

    private void Update()
    {
        float randomSpawn = Random.Range(0f, 1f);
        if (Time.time > spawnTime && randomSpawn >= spawnNoiseOffset)
        {

            float randomType = Random.Range(0f, 1f);
            if (randomType >= typeNoiseOffset)
            {
                Instantiate(enemies[0], new Vector3(transform.position.x + Random.Range(-5f, 5f), transform.position.y), Quaternion.identity);
            }
            else
            {
                Instantiate(enemies[1], new Vector3(transform.position.x + Random.Range(-5f, 5f), transform.position.y), Quaternion.identity);
            }

            spawnTime = Time.time + spawnDelay;
        }
    }
}
