using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    // Here i have created the levels too.
    // Be patients because it's easy to read ;)

    public Transform[] spawnPoints;

    // Enemies prefabs
    public GameObject enemyGreenPrefab;
    public GameObject enemyRedPrefab;
    public GameObject enemyBluePrefab;

    public float timeToSpawn = 3f;
    public float timeBetweenWaves = 1f;

    float timeLevelOne = 30f;
    float timeLevelTwo = 60f;

    void Update()
    {
        if (Time.timeSinceLevelLoad >= timeToSpawn)
        {
            SpawnNewEnemy();
            timeToSpawn = Time.timeSinceLevelLoad + timeBetweenWaves;
        }
    }

    //---------------------------------------------
    void SpawnNewEnemy()
    {
        int randomNumber = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            // Level I
            if (i == randomNumber && Time.timeSinceLevelLoad <= timeLevelOne)
            {
                Instantiate(enemyGreenPrefab, spawnPoints[i].position, Quaternion.identity);
            }
                
            // Level II
            else if (i == randomNumber && Time.timeSinceLevelLoad > timeLevelOne && Time.timeSinceLevelLoad <= timeLevelTwo)
            {
                Instantiate(enemyRedPrefab, spawnPoints[i].position, Quaternion.identity);
                timeBetweenWaves = 0.5f;
            }

            // Level III
            else if (i == randomNumber && Time.timeSinceLevelLoad > timeLevelTwo)
            {
                Instantiate(enemyBluePrefab, spawnPoints[i].position, Quaternion.identity);
                timeBetweenWaves = 0.5f;
            }
        }
    }
}
