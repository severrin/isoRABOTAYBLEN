using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoButtons : MonoBehaviour
{
    public GameObject stopper;
    public GameObject spawner;
    public GameObject black;

    public GameObject win;

    public void TurnOff ()
    {
        stopper.GetComponent<EdgeCollider2D>().enabled = false;
        Object.Destroy(spawner);

        black.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);

        Win();
    }

    void Win()
    {
        win.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        
    }



}
