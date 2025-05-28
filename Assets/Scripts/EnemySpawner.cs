using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject galagaEnemy;


    // Start is called before the first frame update
    
    void SpawnEnemy()
    {
        Instantiate(galagaEnemy, new Vector2(Random.Range(-8, 8), Random.Range(1, 3)), Quaternion.identity);
    }
    
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
