using UnityEngine;
using System.Collections;

public class MoverFaca : MonoBehaviour {

	[SerializeField]
	Vector3 goTo, goBack;
    [SerializeField]
	float timeToGo, delay;
	// Use this for initialization
	void Start () {
    
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Center")
        {
            Return();
            Debug.Log(other.tag);
        }
    }
	public void Stab()
	{
		gameObject.MoveTo(goTo, timeToGo, delay);
	}
    public void Return()
    {
        gameObject.MoveTo(goBack, 0.5f, 0.5f);
    }
}
