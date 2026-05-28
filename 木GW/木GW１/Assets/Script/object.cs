using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject fallingPrefab;

    // ê∂ê¨îÕàÕ
    public float minX = -8f;
    public float maxX = 8f;

    // ê∂ê¨çÇÇ≥
    public float spawnY = 6f;

    // ê∂ê¨ä‘äu
    public float spawnInterval = 1f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 1f, spawnInterval);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);

        Vector2 spawnPosition = new Vector2(randomX, spawnY);

        Instantiate(fallingPrefab, spawnPosition, Quaternion.identity);
    }
}