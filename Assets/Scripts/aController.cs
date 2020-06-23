﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aController : MonoBehaviour
{
   // public CharacterController2D controller;

    public float speed = 2f;
    public Animator animator;


   // float horizontalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //если написать Input.GetAxisRaw - он будет только 0 или 1 (не будет инерции)
        float verticalMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        animator.SetFloat("Speed2", Mathf.Abs(verticalMove));

        transform.position += new Vector3(horizontalMove, verticalMove, 0f);
    }
}
