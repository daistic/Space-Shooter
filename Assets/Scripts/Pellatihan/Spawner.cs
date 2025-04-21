using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] float spawnDelay;
    [SerializeField, Range(0f, 1f)] float typeNoiseOffset;

    private float spawnTime;

    private void Update()
    {
        if (Time.time > spawnTime)
        {
            if (Random.Range(0f, 1f) > typeNoiseOffset)
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
