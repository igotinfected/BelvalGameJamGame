using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parachute : MonoBehaviour
{
    public float dropParachuteTimer = 4;
    float time;
    GameObject ball;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "VituvianBall" && ball == null)
        {
            ball = collision.gameObject;
            time = Time.time;
        }
    }

    private void Update()
    {
        Debug.Log(Time.time - time);
        if (ball != null && Time.time - time < dropParachuteTimer)
        {
            gameObject.transform.position = ball.transform.position + new Vector3(0,1);
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 225));
        }
    }

}
