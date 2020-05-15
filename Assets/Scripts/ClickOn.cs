using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    public GameObject stopper;
    public GameObject end;

    public GameObject uved;

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other)
    {
        uved = other.gameObject;
          
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Debug.Log("You Click");
            Destroy(uved);
        
           //stopper.GetComponent<EdgeCollider2D>().enabled = false;
           //StartCoroutine(Waiting());
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
