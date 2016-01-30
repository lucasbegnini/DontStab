using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	public void Reset()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Menu()
	{
		Application.LoadLevel ("menu");
	}
}
