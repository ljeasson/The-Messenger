using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour {

	// Health stats
	public int playerHealth = 100;
	public int maxHealth = 100;

	// Health potion stats
	public int currentHealthPotionCount = 2;
	public int maxHealthPotionCount = 5;

	// Carry weight stats
	public float currentWeight = 0.0f;
	public float weightLimit = 20.0f;

	// Coin stats
	public int coinCount = 0;
	public int maxCoinCount = 100; 

	// Time left until player dies from the plague
	public float timeLeft = 10.0f;

	// Death status indicator
	public bool isDead = false;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () 
	{
		// Decrement time until it reaches zero
		if (timeLeft >= 0)
			timeLeft -= Time.deltaTime;

		// If run out of time, player is dead
		if (timeLeft < 0) {
			timeLeft = 0;
			isDead = true;
		}

		// Use 1 health potion to replenish health and gain a little bit of time
		if (Input.GetKeyDown (KeyCode.F) && currentHealthPotionCount > 0) {
			currentHealthPotionCount -= 1;
			playerHealth += 10;
			timeLeft += 25;
		}
	}		
}
