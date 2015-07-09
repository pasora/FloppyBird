using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
	bool gameState = true;
	int CurrentScore = 0;
	string HighScoreKey = "highScore"; 
	public Text scoreText;
	public GameObject gameoverTextObj;
	public Text gameoverText;

	// Use this for initialization
	void Start () {
		gameoverTextObj.GetComponent<Text> ().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameState) {
			AddScore ();
		}
	}

	int GetHighScore() {
		return PlayerPrefs.GetInt (HighScoreKey, 0);
	}

	void SetHighScore() {
		PlayerPrefs.SetInt (HighScoreKey, CurrentScore);
		PlayerPrefs.Save ();
	}

	public void AddScore() {
		CurrentScore++;
		scoreText.text = "Score: " + CurrentScore;
	}

	public void ChangeGameoverState() {
		gameState = false;
		gameoverTextObj.GetComponent<Text> ().enabled = true;
		gameoverText.text = "GAMEOVER\nYour score is " + CurrentScore + ".";
		SetHighScore ();
	}

}
