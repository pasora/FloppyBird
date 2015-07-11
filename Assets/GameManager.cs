using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
	bool gameState = true;
	int CurrentScore = 0;
	public int frame;
	public int count;
	string HighScoreKey = "highScore"; 
	public Text scoreText;
	public GameObject gameoverTextObj;
	public Text gameoverText;
	const int MAGNET_NUM = 10;
	public GameObject MagnetPrefab;
	GameObject[] magnet = new GameObject[MAGNET_NUM];

	// Use this for initialization
	void Start () {
		gameoverTextObj.GetComponent<Text> ().enabled = false;	
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		frame++;
		if (gameState) {
			AddScore ();
		} else {
			if (Input.GetMouseButtonDown(0)) {
				Application.LoadLevel("Title");
			}
		}

		if (i < MAGNET_NUM && frame % count == 0 ) {
			magnet[i] = (GameObject)Instantiate (MagnetPrefab, new Vector2 (10, Random.Range (-10, 5)), Quaternion.identity);
			i++;
		}
	}

	int GetHighScore() {
		return PlayerPrefs.GetInt (HighScoreKey, 0);
	}

	void SetHighScore(int score) {
		if (score > GetHighScore ()) {
			PlayerPrefs.SetInt (HighScoreKey, CurrentScore);
			PlayerPrefs.Save ();
		}
	}

	public void AddScore() {
		if (frame % count == 0) {
			CurrentScore++;
		}
		scoreText.text = "Score: " + CurrentScore ;
	}

	public void ChangeGameoverState() {
		gameState = false;
		gameoverTextObj.GetComponent<Text> ().enabled = true;
		gameoverText.text = "GAMEOVER\nYour score is " + CurrentScore + ".";
		SetHighScore (CurrentScore);
	}

}
