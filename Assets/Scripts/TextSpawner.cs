using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawner : MonoBehaviour
{
    public GameObject[] enemyText;
    int randomEnemy;
    float randX = 27.8f;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            randomEnemy = Random.Range(0, enemyText.Length);
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemyText [randomEnemy], whereToSpawn, Quaternion.identity);
        }
    }
}
