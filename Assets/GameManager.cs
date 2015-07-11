using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
	bool gameState = true;
	int CurrentScore = 0;
	public int frame;
	public int count;
	string HighScoreKey = "highScore";
	public Canvas canvas;
	public Text scoreText;
	public GameObject gameoverTextObj;
	public Text gameoverText;
	public GameObject MagnetPrefab;
	GameObject[] magnet = new GameObject[10000];
	int i = 0;

	// Use this for initialization
	void Start () {
		gameoverTextObj.GetComponent<Text> ().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		if (gameState) {
			AddScore ();
		} else {
			//if (Input.GetMouseButtonDown(0)) {
			if (Input.GetTouch(0).phase == TouchPhase.Began) {
				Application.LoadLevel("Title");
			}
		}

		if (frame % count == 0 ) {
			magnet[i] = (GameObject)Instantiate (MagnetPrefab);
			magnet[i].transform.SetParent(canvas.transform);
			magnet[i].transform.localPosition = new Vector3(600, Random.Range(-960, 960), 0);
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

	void AddScore() {
		if (frame % count == 0) {
			CurrentScore++;
		}
		scoreText.text = "Score: " + CurrentScore;
	}

	public void ChangeGameoverState() {
		gameState = false;
		gameoverTextObj.GetComponent<Text> ().enabled = true;
		gameoverText.text = "GAMEOVER\nYour score is " + CurrentScore + ".";
		SetHighScore (CurrentScore);
	}

}
