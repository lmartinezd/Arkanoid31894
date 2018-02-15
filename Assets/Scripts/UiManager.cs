using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {
	int score=0;
	int total = 28;
	public Text scoreText;
	public Text txtWin;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (total == score) { 
			txtWin.text = "YOU WIN ! \nPress Enter to start again...!";	 
			Time.timeScale = 0f;
			if (Input.GetKeyUp (KeyCode.Return) ) {
				Time.timeScale = 1f;
				SceneManager.LoadScene("game-scene");
			}
		}		
	}

	public void IncrementScore(){
		score++;
		scoreText.text = "Score : " + (float)(score * 100);
	}
}
