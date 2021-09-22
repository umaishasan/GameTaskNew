﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float myspeedScript;
    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        //movement for key down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("UpWalk");
            transform.Translate(new Vector3(0, 0, 4f * myspeedScript) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("DownWalk");
            transform.Translate(new Vector3(0, 0, -4f * myspeedScript) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("jump");
            transform.Translate(new Vector3(0, 4*1, 0) * Time.deltaTime);
        }

        //rotation
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -10f * 1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 10f * 1, 0) * Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
        this.enabled = true;
    }
}
