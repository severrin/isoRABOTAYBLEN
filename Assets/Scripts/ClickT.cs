using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickT : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickablesLayer;

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D rayHit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, clickablesLayer);


            if (hit)
            {
                hit.collider.GetComponent<ClickOnT>().ClickMe();
            }

        }



    }
}
