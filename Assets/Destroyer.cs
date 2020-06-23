using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject uved;

    void OnTriggerEnter2D(Collider2D other)
    {
        uved = other.gameObject;
        Destroy(uved);

    }



}
