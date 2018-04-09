using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Handles events for Play button
	public void play ()
	{
		// Scene 1 = Player Test
		SceneManager.LoadScene (1);
	}

	// Handles events for Settings button
	public void settings ()
	{
		// TODO: Add settings room
	}

	// Handles events for Quit button
	public void quit ()
	{
		// Exits application
		Application.Quit ();
	}


	void Start ()
	{
		// Enables mouse cursor in Menu scene
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
		
}
