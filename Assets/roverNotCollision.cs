﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roverNotCollision : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Planet"))
        {
            anim.SetBool("Crash", true);
            Debug.Log("test");
        }
    }

}