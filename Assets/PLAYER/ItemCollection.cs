using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour {

	// Initialize Raycast and Raycast distance
	RaycastHit hit;
	float distance;

	// Reference to GameObject (usually a reference to the Player itself)
	GameObject go;
	PlayerStatus p;

	void Start () 
	{
		// Initialize GameObject reference to Player
		go = GameObject.Find("Player");
		// Initialize reference to PlayerStatus script
		// (used to access player status variables)
		p = go.GetComponent<PlayerStatus>();
	}

	void Update () {
		
		// Debug Raycast in Editor - SO WE CAN SEE IT! MAKES LIFE EASIER!
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 10;
		Debug.DrawRay (transform.position, forward, Color.green);

		// Detect Raycast Hit
		if (Physics.Raycast(transform.position, (forward), out hit)) {
			distance = hit.distance;
			print ("Distance: " + distance + "     Tag: " + hit.collider.gameObject.tag);

			// ADD OBJECTS THAT THE PLAYER CAN COLLECT HERE

			// If Raycast hits an object with tag "Coin" and E is pressed
			if (Input.GetKeyDown (KeyCode.E) && distance <= 0.5 && hit.collider.gameObject.tag == "Coin") {
				p.coinCount += 1;
				Destroy (hit.collider.gameObject);
			}

			// If Raycast hits an object with tag "Coin" and E is pressed
			if (Input.GetKeyDown (KeyCode.E) && distance <= 0.5 && hit.collider.gameObject.tag == "Potion") {
				p.currentHealthPotionCount += 1;
				Destroy (hit.collider.gameObject);
			}

			// Add more items
		}

	}
}
