using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public void play ()
	{
		SceneManager.LoadScene (1);
	}

	public void settings ()
	{
		
	}

	public void quit ()
	{
		Application.Quit ();
	}

	public void levelSelect (int level)
	{
		SceneManager.LoadScene (level);
	}


	void Start ()
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.Quit ();
		}
	}

}
