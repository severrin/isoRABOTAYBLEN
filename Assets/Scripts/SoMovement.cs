using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoMovement : MonoBehaviour
{
    public float speed = 5f;
    public Transform textbox;

    void Update()
    {
        textbox.transform.position += Vector3.down * speed * Time.deltaTime;

    }
}
