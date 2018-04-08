using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public delegate void GameDelegate();
	public static event GameDelegate OnGameStarted;
	public static event GameDelegate OnGameOverConfirmed;

	public static GameManager Instance;

	public GameObject startPage;
	public GameObject gameOverPage;
	public GameObject countDownPage;
	public Text scoreText;

	enum PageState {
		None, 
		Start,
		GameOver,
		Countdown
	}

	int score = 0;
	bool gameOver = false;

	public bool GameOver { get { return gameOver; } }

	void Awake() {
		Instance = this;
	}

	void SetPageState(PageState state) {
		startPage.SetActive(state == PageState.Start);
		gameOverPage.SetActive(state == PageState.GameOver);
		countDownPage.SetActive(state == PageState.Countdown);
	}

	public void ConfirmGameOver() {
		// activated when replay button is hit
	}

	public void StartGame(){
		// activated when play button is hit
	}
}
