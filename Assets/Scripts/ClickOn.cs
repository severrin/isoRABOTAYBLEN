using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    public GameObject stopper;
    public GameObject end;
    // Update is called once per frame


    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            {
                Debug.Log("You Click");
            stopper.GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(Waiting());
            }
            
            
        }

    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(0.5f);
        stopper.GetComponent<BoxCollider2D>().enabled = true;

    }


    private void OnMouseUp()
    {
        
    }
}
