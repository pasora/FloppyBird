using UnityEngine;
using System.Collections;

public class Floppy : MonoBehaviour {
	float FloppySpeed = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			FloppySpeed = 20;
		}
		FloppySpeed -= 0.5f;
		transform.Translate (transform.up * FloppySpeed);
	
	}

	void OnColisionEnter2D(Collision2D collision) {
		GameObject go = GameObject.Find ("GameObject");
		if (collision.gameObject.name == "Top" || collision.gameObject.name == "Bottom") {
			if (go != null) {
				GameManager gm = go.GetComponent (typeof(GameManager)) as GameManager;
				gm.ChangeGameoverState ();
			}
		}
	}
}
