using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

	// // Text for displaying Health
	public Text healthText;
	// Text for displaying Weight
	public Text weightText;
	// // Text for displaying Potion count
	public Text potionCountText;
	// Text for displaying Time left
	public Text timeText;
	// Text for displaying Coin count
	public Text coinText;
	// Text for isplaying death message
	public Text deathText;

	// Reference to GameObject (usually a reference to the Player itself)
	GameObject go;
	PlayerStatus p;

	// Use this for initialization
	void Start () 
	{
		// Initialize death text as blank;
		deathText.text = "";	

		// Initialize GameObject reference to Player
		go = GameObject.Find("Player");
		// Initialize reference to PlayerStatus script
		// (used to access player status variables)
		p = go.GetComponent<PlayerStatus>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// UI
		healthText.text = "HP: " + p.playerHealth;
		weightText.text = "Weight: " + p.currentWeight;
		timeText.text = "Time: " + p.timeLeft;
		potionCountText.text = "Potions: " + p.currentHealthPotionCount;
		coinText.text = "Coin: " + p.coinCount;

		// Show Game Over message if player is dead
		if (p.isDead == true)
			Death ();
	}

	public void Death ()
	{
		deathText.text = "You Have Perished";
	}
}
