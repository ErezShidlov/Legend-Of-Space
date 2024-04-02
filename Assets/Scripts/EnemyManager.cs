using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    Vector2 randomSpawnPos;

    void Start()
    {
        InvokeRepeating(nameof(CreateEnemy), 0, 3.5f);
    }
    
    void Update()
    {

    }
 
    void CreateEnemy()
    {
        for (int i = 0; i < 4; i++)
        {
            randomSpawnPos.x = Random.Range(-10, 11);
            randomSpawnPos.y = Random.Range(5, 8);
            GameObject temp = Instantiate(EnemyPrefab, randomSpawnPos, transform.rotation);
        }
    }
}
