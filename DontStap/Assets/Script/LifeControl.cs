using UnityEngine;
using System.Collections;

public class LifeControl : MonoBehaviour {

	[SerializeField]
	GameObject[] faca;

	private int facada;

	[SerializeField]
	GameObject GameOverPanel;
	// Use this for initialization
	void Start () {
		facada = 0;
		for(int i=0; i< faca.Length; i++)
		{
			faca[i].SetActive(false);
		}
	
	}

	public void dano()
	{
		faca [facada].SetActive (true);
		facada++;

		if (facada == faca.Length) 
		{
			StartCoroutine(gameOver ());
		}

	}

	IEnumerator gameOver()
	{
		GameObject.FindGameObjectWithTag ("voodoo").GetComponent<Animator> ().SetTrigger ("diehit");
		yield return new WaitForSeconds (1.5f);
		GameOverPanel.SetActive (true);

	}
}
