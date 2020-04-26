using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	public bool autoPlay = false;
	private Ball ball;
	float xmin;
	float xmax;
	public float speed = 15.0f; 
	
	
	
	// Use this for initialization
	void Start () {
		
		Vector3 leftmost = new Vector3(1.5f, 0, 0);
		Vector3 rightmost = new Vector3(14.5f, 0, 0);
		xmin = leftmost.x;
		xmax = rightmost.x;
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse ();
		} 
		
	}
	
	void MoveWithMouse(){
		if (Input.GetKey (KeyCode.LeftArrow)) {
			//transform.position += new Vector3 (-speed * Time.deltaTime,0f,0);
			transform.position += Vector3.left * speed  * Time.deltaTime ;
		}else if(Input.GetKey (KeyCode.RightArrow)) {
			//transform.position += new Vector3 (+speed * Time.deltaTime,0f,0);
			transform.position += Vector3.right * speed  * Time.deltaTime ;
		}
		//Restrict Player to the gamespace
		float newX = Mathf.Clamp (transform.position.x, xmin, xmax);
		transform.position = new Vector3 (newX,1.5f, 14.5f);
	}
}
