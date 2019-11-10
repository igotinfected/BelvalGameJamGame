using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placement_rules : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }
    //trigger when overlap, collision on touch
    void OnTriggerStay2D (Collider2D collision) {

        Debug.Log ("touching frame");

        gameObject.GetComponent<Renderer> ().material.color = Color.red;

    }
    void OnTriggerExit2D (Collider2D other) {
        gameObject.GetComponent<Renderer> ().material.color = Color.white;

    }

}