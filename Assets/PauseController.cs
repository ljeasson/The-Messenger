using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

	public Transform menu;
	public Transform UI;
	public Transform player;

	void Start ()
	{
		// Let mouse be visible on instantiation
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Pause ();
		}
	}

	public void Pause() 
	{
		// If pause menu is not shown and UI is shown
		if (menu.gameObject.activeInHierarchy == false && UI.gameObject.activeInHierarchy == true) {
			//Disable UI and enable Pause Menu 
			menu.gameObject.SetActive (true);
			UI.gameObject.SetActive (false);

			// Stop time
			Time.timeScale = 0;

			// Disable First Person Controller
			// (prevents looking around with the mouse even while paused)
			player.GetComponent<FirstPersonController> ().enabled = false;

			// Let Mouse pointer be visible
			Cursor.visible = true;
		} 
		else {
			//Disable Pause Menu and enable UI 
			menu.gameObject.SetActive (false);
			UI.gameObject.SetActive (true);

			// Start time
			Time.timeScale = 1;

			// Enable First Person Controller
			player.GetComponent<FirstPersonController> ().enabled = true;

			// Let Mouse pointer be invisible
			Cursor.visible = false;
		}
	}
		
	public void Quit ()
	{
		SceneManager.LoadScene (0);
	}
}
