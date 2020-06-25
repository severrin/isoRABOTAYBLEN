using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    public GameObject stopper;
    public GameObject uved;

    public GameObject other;


    // Update is called once per frame
    private void Start()
    {
        Invoke("tryOther", 15f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        uved = other.gameObject;
          
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Destroy(uved);


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

    void tryOther()
    {
        other.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }
    
}
