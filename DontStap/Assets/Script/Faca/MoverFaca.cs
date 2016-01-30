using UnityEngine;
using System.Collections;

public class MoverFaca : MonoBehaviour {

	[SerializeField]
	Vector3 goTo;
	float timeToGo;
	// Use this for initialization
	void Start () {
	
	}
	
	public void Move()
	{
		gameObject.MoveTo (goTo, timeToGo, 0.0f);
	}
}
