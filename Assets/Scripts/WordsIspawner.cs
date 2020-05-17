using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordsIspawner : MonoBehaviour
{
    int randomEnemy;
    public GameObject[] enemyText;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("StopSpawning", 12);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            randomEnemy = Random.Range(0, enemyText.Length);
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-1.8f, 7.7f);
            randY = Random.Range(3.85f, -3.8f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemyText[randomEnemy], whereToSpawn, Quaternion.identity);
        }
    }

    public void StopSpawning()
    {
        Object.Destroy(spawner);
    }
}
