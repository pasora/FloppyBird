using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
	int CurrentScore = 0;
	string HighScoreKey = "highScore"; 
	public Text label;
	 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		AddScore ();
	
	}

	int GetHighScore() {
		return PlayerPrefs.GetInt (HighScoreKey, 0);
	}

	void SetHighScore() {
		PlayerPrefs.SetInt (HighScoreKey, CurrentScore);
		PlayerPrefs.Save ();
	}

	void AddScore() {
		CurrentScore++;
		label.text = "Score: " + CurrentScore;
	}

	void OnColissionEnter2D(Collision2D collision) {
		if (collision.gameObject.name == "Wall") {

		}
	}
}
