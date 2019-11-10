﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour, IPointerClickHandler
{
	public Rigidbody2D ballRigidbody;
	
	void Start () {
		ballRigidbody.simulated = false;
        DragStopper.dragEnabled = true;
	}


	public void OnPointerClick(PointerEventData eventData) {
		ballRigidbody.simulated = true;
		DragStopper.dragEnabled = false;
		Destroy(gameObject);
	}
}
