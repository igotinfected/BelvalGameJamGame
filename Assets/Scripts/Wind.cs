using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float windForceMultiplier = 10f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "VituvianBall")
        {
            Vector2 wind = collision.transform.position - this.transform.position;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(wind);
        }
    }
}
