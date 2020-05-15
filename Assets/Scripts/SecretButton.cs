using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretButton : MonoBehaviour
{
    public GameObject stopper;
    public GameObject spawner;

    private void OnMouseEnter()
    {
       
            Debug.Log("SECRET REVEALED");
        if (Input.GetMouseButtonDown(0))
        {

            stopper.GetComponent<BoxCollider2D>().enabled = false;
            Object.Destroy(spawner);
        }

    }
}
