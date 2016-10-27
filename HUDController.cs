/*COMP3064-Assignment1
 * Project Name: Air Flight
 * File Name: Sky Controller
 * Author: Heng Wang
 * Student ID: 100976892
 * Last Modified by: Heng Wang
 * Last Modified Date: Oct 26, 2016
 * */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	//Create fields for points
	[SerializeField]
	Text points = null;
	//Create fields for health
	[SerializeField]
	Text health = null;
	//Create fields for restart button
	[SerializeField]
	Button restartBtn = null;
	//Create fields for game over
	[SerializeField]
	Text gameOverLabel = null;
	//Create fields for player
	[SerializeField]
	GameObject player = null;
	//Create fields for highest score
	[SerializeField]
	Text highScore = null;

	// Bind UI and Reset game
	void Start () {

		Player.Instance.hud = this;
		RestartGame ();
	}


	//Update points label text
	public void UpdatePoints(){

		points.text = "Points: " + Player.Instance.Points;

	}
	//Update health label text
	public void UpdateHealth(){
		
		health.text = "Health: " + Player.Instance.Health;
	}
	//Game Over 
	public void GameOver(){

		//Hide  health and points labels
		points.gameObject.SetActive(false);
		health.gameObject.SetActive(false);


		//Disable player
		player.gameObject.SetActive(false);

		//Display "Game Over"
		gameOverLabel.gameObject.SetActive(true);
		//Display High Score
		highScore.gameObject.SetActive (true);
		highScore.text = "High Score: " + Player.Instance.HighScore+
			"\nYour Score: "+ Player.Instance.Points;

		//Display "Restart" button
		restartBtn.gameObject.SetActive (true);

	}
	//Restart Game
	public void RestartGame(){

		//Show  points and health
		points.gameObject.SetActive(true);
		health.gameObject.SetActive(true);
		//Reset points and health
		Player.Instance.Points = 0;
		Player.Instance.Health = 5;

		//Show player
		player.gameObject.SetActive(true);


		//Hide "Gamer Over", restart button and high score
		gameOverLabel.gameObject.SetActive(false);
		restartBtn.gameObject.SetActive (false);
		highScore.gameObject.SetActive (false);



	}
}
