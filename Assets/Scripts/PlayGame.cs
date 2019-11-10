using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour, IPointerClickHandler
{
	public Rigidbody2D ballRigidbody;


	void Start () {
        ballRigidbody.simulated = false;
        Globals.dragEnabled = true;
	}

	public void OnPointerClick(PointerEventData eventData) {
		ballRigidbody.simulated = true;
		Globals.dragEnabled = false;
        UnlockHinges();
        Destroy(gameObject);
	}

    private void UnlockHinges()
    {
     GameObject[] hinges = GameObject.FindGameObjectsWithTag("Hinge");
        foreach(GameObject hinge in hinges)
        {
            hinge.GetComponent<Rigidbody2D>().freezeRotation = false;
        }
    }
}
