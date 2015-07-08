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
}
