using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {
	private Vector2 startPos;
	private Vector2 endPos;
    public int offset;
    private bool movedFlag = true;
	private bool directionChosen;


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
                gameObject.MoveTo((new Vector3(-3.0f, 0, 0)), 0.5f,0);
			}
			if((startPos.x < endPos.x) && (Mathf.Abs(startPos.y - endPos.y) < offset))
			{
                //foi pra direita
                gameObject.MoveTo((new Vector3(3.0f, 0, 0)), 0.5f, 0);

            }
            if ((startPos.y < endPos.y) && (Mathf.Abs(startPos.x - endPos.x) < offset))
			{
                //foi pra cima
                gameObject.MoveTo((new Vector3(0, 3.0f, 0)), 0.5f, 0);

            }
            if ((startPos.y > endPos.y) && (Mathf.Abs(startPos.x - endPos.x) < offset))
			{
                //foi pra baixo
                gameObject.MoveTo((new Vector3(0, -3.0f, 0)), 0.5f, 0);
            }
            startPos.Set(0, 0);
            endPos.Set(0, 0);
            directionChosen = false;
        }
        if (Mathf.Abs(gameObject.transform.position.x) == 3 || Mathf.Abs(gameObject.transform.position.y) == 3)
        {
            gameObject.MoveTo(Vector3.zero, 1f, 1f);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "CAPIROTAGEM")
        {
            Return();
            Debug.Log(other.tag);
        }
    }
    public void Return()
    {
        gameObject.MoveTo(Vector3.zero, 1f, 1f);
    }
}
