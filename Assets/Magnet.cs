using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour {
	public int speed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (- speed, 0);
		GetComponent<Rigidbody2D> ().AddTorque (200.0f, new ForceMode2D());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
