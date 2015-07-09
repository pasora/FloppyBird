using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour {
	public Text label;
	string HighScoreKey = "highScore";


	// Use this for initialization
	void Start () {
		label.text = "High Score: " + GetHighScore ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel ("Game");
		}
	}

	int GetHighScore() {
		return PlayerPrefs.GetInt (HighScoreKey, 0);
	}
}
