using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    public bool Spreading;

    public GameObject[] gameObjects;

    void Start()
    {
        StartCoroutine(Lockdown());
        Spreading = false;
    }

    IEnumerator Lockdown()
    {
        yield return new WaitForSeconds(50f);
        Spreading = true;
    }

    public void Update()
    {
        if (Spreading is true)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }
        }
    }

   


}
