using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour, IPointerClickHandler
{
	public Rigidbody2D ballRigidBody = null ;
	
	public void OnPointerClick(PointerEventData eventData) {
		ballRigidBody.simulated = true;
		Destroy(gameObject);
	}
}
