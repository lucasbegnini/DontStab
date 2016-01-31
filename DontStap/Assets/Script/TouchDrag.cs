using UnityEngine;
using System.Collections;
[System.Serializable]
public class Bounds
{
    public float max, min;
}
public class TouchDrag : MonoBehaviour 
{
    public Bounds boundary;
	public char lockXY = 'n'; // LockXY diz se o objeto vai mover na vertical, horizontal ou é livre.
    private Vector3 screenPoint;
	private Vector3 offset;
	private Vector3 curScreenPoint;
	private Vector3 curPosition;
	private Vector3 var;

	void OnMouseDown()
	{
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z ));
	}
	void OnMouseDrag()
	{
		curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			
		curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		var.Set(curPosition.x, curPosition.y, curPosition.z);
		transform.position = var;
	}
}









