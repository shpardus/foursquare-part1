using UnityEngine;
using System.Collections;

public class Controller2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		// When 'T' key is pressed, goes straight
		if ( Input.GetKey (KeyCode.T) || Input.GetKey (KeyCode.UpArrow) ) {
			GetComponent<Rigidbody>().AddForce( GetComponent<Transform>().forward * 2f, ForceMode.VelocityChange );
		}
		else if ( Input.GetKey (KeyCode.G) || Input.GetKey (KeyCode.DownArrow) ) {
			GetComponent<Rigidbody>().AddForce( GetComponent<Transform>().forward * -1, ForceMode.VelocityChange );
		}
		else {
			GetComponent<Rigidbody>().velocity = Physics.gravity;
		}
		
		// TURNING.
		if ( Input.GetKey (KeyCode.F) || Input.GetKey (KeyCode.LeftArrow) ) {
			transform.Rotate (new Vector3 (0f, -5f, 0f) );
		}
		else if ( Input.GetKey (KeyCode.H) || Input.GetKey (KeyCode.RightArrow) ) {
			transform.Rotate (new Vector3 (0f, 5f, 0f) );
		}

	}
}
