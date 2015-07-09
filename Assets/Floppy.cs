using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Floppy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<Rigidbody2D>().AddForce (Vector2.up * 3000);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		GameObject go = GameObject.Find ("GameObject");
		if (collision.gameObject.name == "Top") {
			if (go != null) {
				GameManager gm = go.GetComponent (typeof(GameManager)) as GameManager;
				gm.ChangeGameoverState ();
			}
		}
		if (collision.gameObject.name == "Bottom") {
			if (go != null) {
				GameManager gm = go.GetComponent (typeof(GameManager)) as GameManager;
				gm.ChangeGameoverState ();
			}
		}

	}
}
