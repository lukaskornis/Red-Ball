using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnDelay;
    public GameObject enemy;

    float delay;
    void Start()
    {
        delay = spawnDelay;
    }

    void Update()
    {
        spawnDelay -= Time.deltaTime;
        if (spawnDelay <= 0 )
        {
            Spawn();
        }
    }

    void Spawn()
    {
        var rotation = Random.rotation;
        rotation.x = 0;
        rotation.y = 0;

        Instantiate(enemy, transform.position + Random.insideUnitSphere * 2, rotation);

        spawnDelay = delay + Random.Range(-.5f, .5f);
    }
}