using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour {

	// Health stats
	public int playerHealth = 100;
	public int maxHealth = 100;
	public Text healthText;

	// Health potion stats
	public int currentHealthPotionCount = 2;
	public int maxHealthPotionCount = 5;
	public Text potionCountText;

	// Carry weight stats
	public float currentWeight = 0.0f;
	public float weightLimit = 20.0f;
	public Text weightText;

	// Time left until player dies from the plague
	public float timeLeft = 10.0f;
	public Text timeText;

	// Text for Displaying death message
	public Text deathText;

	// Use this for initialization
	void Start ()
	{
		// Initialize death text as blank;
		deathText.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
		// UI
		healthText.text = "HP: " + playerHealth;
		weightText.text = "Weight: " + currentWeight;
		timeText.text = "Time: " + timeLeft;
		potionCountText.text = "Potions: " + currentHealthPotionCount;

		// Decrement time until it reaches zero
		if (timeLeft >= 0)
			timeLeft -= Time.deltaTime;

		// If run out of time, player is dead
		if (timeLeft < 0)
			Dead ();

		// Use 1 health potion to replenish health and gain a little bit of time
		if (Input.GetKeyDown (KeyCode.E) && currentHealthPotionCount > 0) {
			currentHealthPotionCount -= 1;
			playerHealth += 10;
			timeLeft += 25;
		}
	}

	// Method for player death
	void Dead ()
	{
		deathText.text = "You Have Perished";
	}
}
