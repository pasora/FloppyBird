using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Floppy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetTouch(0).phase == TouchPhase.Began) {
			GetComponent<Rigidbody2D>().velocity = Vector2.up * 1500;
		}
	}

	void FixedUpdate() {

	}

	void OnCollisionEnter2D(Collision2D collision) {
		GameObject go = GameObject.Find ("GameObject");
		GameManager gm = go.GetComponent (typeof(GameManager)) as GameManager;
		Destroy (collision.gameObject);
		gm.ChangeGameoverState ();
	}
}
