using UnityEngine;
using System.Collections;

public class MoverFaca : MonoBehaviour {

	public Vector3 goTo, goBack;
    public GameObject sombra;

    [SerializeField]
	float timeToGo;
	
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Center")
        {
            Return();
            sombra.SetActive(false);
        }
    }
	public void Stab(float delay)
	{
        gameObject.FadeTo(1f, 0.1f, 0f);
		gameObject.MoveTo(goTo, timeToGo, delay);
	}
    public void Return()
    {
        gameObject.FadeTo(0.0f, 0.2f, 0);
        gameObject.MoveTo(goBack, 0.1f, 0.2f);
    }
}
