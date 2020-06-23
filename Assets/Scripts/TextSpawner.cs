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

        StartCoroutine(Stage1());
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            if (spawnRate > 1.1)
            {
                randomEnemy = Random.Range(0, 3);
                nextSpawn = Time.time + spawnRate;
                whereToSpawn = new Vector2(randX, transform.position.y);
                Instantiate(enemyText[randomEnemy], whereToSpawn, Quaternion.identity);
            }
            
            else
            {
                randomEnemy = Random.Range(4, 8);
                nextSpawn = Time.time + spawnRate;
                whereToSpawn = new Vector2(randX, transform.position.y);
                Instantiate(enemyText[randomEnemy], whereToSpawn, Quaternion.identity);
            }
        }
    }

   
    IEnumerator Stage1()
    {
        yield return new WaitForSeconds(10f);
      
        spawnRate = 1f;

        StartCoroutine(Stage2());
    }

    IEnumerator Stage2()
    {
        yield return new WaitForSeconds(10f);
        StopCoroutine(Stage1());

        spawnRate = 0.5f;

        StartCoroutine(Stage3());
       
    }

    IEnumerator Stage3()
    {
        StopCoroutine(Stage2());
        yield return new WaitForSeconds(10f);
        spawnRate = 0.3f;

    }



}
