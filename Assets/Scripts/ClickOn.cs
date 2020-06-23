using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    public GameObject stopper;
    public GameObject end;
    public GameObject uved;

    public GameObject stopper2;
    public GameObject spawner;


    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other)
    {
        uved = other.gameObject;
          
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(uved);

            stopper2.GetComponent<EdgeCollider2D>().enabled = false;
            Object.Destroy(spawner);


        }
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(0.5f);
        stopper.GetComponent<EdgeCollider2D>().enabled = true;
    
    }


    private void OnMouseUp()
    {
        
    }

    
}
