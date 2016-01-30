using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {
	public Vector2 startPos;
	public Vector2 endPos;
    public int offset;
	public bool directionChosen;

	void Update() {
		// Track a single touch as a direction control.
		if (Input.touchCount > 0) {
			var touch = Input.GetTouch(0);
			
			// Handle finger movements based on touch phase.
			switch (touch.phase) {
				// Record initial touch position.
			case TouchPhase.Began:
				startPos = touch.position;
				directionChosen = false;
				break;
				// Report that a direction has been chosen when the finger is lifted.
			case TouchPhase.Ended:
				endPos = touch.position;
				directionChosen = true;
				break;
			}

		}
		if (directionChosen) {
			if((startPos.x > endPos.x) && (Mathf.Abs(startPos.y - endPos.y) < offset))
			{
                //foi pra esquerda
                gameObject.transform.position = new Vector3(-3, 0, 0);
			}
			if((startPos.x < endPos.x) && (Mathf.Abs(startPos.y - endPos.y) < offset))
			{
                //foi pra direita
                gameObject.transform.position = new Vector3(3, 0, 0);

            }
            if ((startPos.y < endPos.y) && (Mathf.Abs(startPos.x - endPos.x) < offset))
			{
                //foi pra cima
                gameObject.transform.position = new Vector3(0, 3, 0);

            }
            if ((startPos.y > endPos.y) && (Mathf.Abs(startPos.x - endPos.x) < offset))
			{
                //foi pra baixo
                gameObject.transform.position = new Vector3(0, -3, 0);

            }
        }
	}
}
