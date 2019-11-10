using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour, IPointerClickHandler
{
	public Rigidbody2D ballRigidbody;

    private GameObject[] gameObjects;
	void Start () {
        ballRigidbody.simulated = false;
        Globals.dragEnabled = true;
	}

	public void OnPointerClick(PointerEventData eventData) {
		ballRigidbody.simulated = true;
		Globals.dragEnabled = false;
        Destroy(gameObject);
	}
}
