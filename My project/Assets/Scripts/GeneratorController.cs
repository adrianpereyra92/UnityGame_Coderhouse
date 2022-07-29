using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    public GameObject [] enemyPrefab;
    public float spawnDelay = 2f;
    public float spawnInterval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemySpawn", spawnDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void EnemySpawn()
    {
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        Instantiate(enemyPrefab[enemyIndex], transform);
    }
   
}
