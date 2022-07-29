using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    public GameObject [] bulletPrefab;
    public float spawnDelay = 2f;
    public float spawnInterval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", spawnDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void Shoot()
    {
        int bulletIndex = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[bulletIndex], transform);
    }
   
}
