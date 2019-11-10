﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parachute : MonoBehaviour
{
    float time;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        time = Time.time;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "VituvianBall" && Time.time- time < 4)
        {
            gameObject.transform.position = collision.gameObject.transform.position + new Vector3(0,1);
            collision.attachedRigidbody.AddForce(new Vector2(0, 9));
        }
    }
}