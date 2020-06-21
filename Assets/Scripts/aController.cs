using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aController : MonoBehaviour
{
    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //если написать Input.GetAxisRaw - он будет только 0 или 1 (не будет инерции)
        float verticalMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position += new Vector3(horizontalMove, verticalMove, 0f);
    }
}
