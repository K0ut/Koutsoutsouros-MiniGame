using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject preFabMine; // Assign your mine prefab in the Inspector
    public int numberOfMines = 6; // Number of mines to spawn
    public Vector3 spawnAreaSize; // Size of the area to spawn mines

    // Start is called before the first frame update
    void Start()
    {
        SpawnMines();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            SpawnMines();
        }

    }
    void SpawnMines()
    {
        for (int i = 0; i < numberOfMines; i++)
        {
            Vector3 randomPosition = new Vector3(
                transform.position.x + Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
                transform.position.y,
                transform.position.z + Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
            );

            Instantiate(preFabMine, randomPosition, Quaternion.identity, transform);
        }
        }
    }
