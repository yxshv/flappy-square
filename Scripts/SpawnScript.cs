using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject spawnPrefab;
    public Transform spawnPos;
    
    float nextSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawn) {
            Vector2 pos = new Vector2(spawnPos.position.x, Random.Range(3 , -3));
            Instantiate(spawnPrefab, pos, Quaternion.identity);
            nextSpawn = Time.time + 1f / spawnRate;
        }
    }
}
