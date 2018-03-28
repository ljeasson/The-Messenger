using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {

	public int playerHealth = 100;
	public int maxHealth = 100;

	// Health potion stats
	public int currentHealthPotionCount = 2;
	public int maxHealthPotionCount = 5;

	// Carry weight stats
	public float currentWeight = 0.0f;
	public float weightLimit = 20.0f;

	// Time left until player dies from the plague
	public float timeLeft = 10.0f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Decrement time until it reaches zero
		if (timeLeft >= 0)
			timeLeft -= Time.deltaTime;

		// If run out of time, player is dead
		if (timeLeft < 0)
			Dead ();

		// Use 1 health potion to replenish health and gain a little bit of time
		if (Input.GetKeyDown (KeyCode.E)) {
			currentHealthPotionCount -= 1;
			playerHealth += 10;
			timeLeft += 25;
		}
	}

	// Method for player death
	void Dead ()
	{
		// Place holder print statement
		print("YOU DIED");
	}
}
