/*COMP3064-Assignment1
 * Project Name: Air Flight
 * File Name: Sky Controller
 * Author: Heng Wang
 * Student ID: 100976892
 * Last Modified by: Heng Wang
 * Last Modified Date: Oct 27, 2016
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
	//Create fields for start button
	[SerializeField]
	Button startBtn = null;
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
	//Create fields for boss
	[SerializeField]
	GameObject boss = null;
	//Create fields for win
	[SerializeField]
	Text win = null;

	//Boss hp pabel
	[SerializeField]
	Text bosshp = null;


	// Bind UI and Reset game
	void Start () {

		Player.Instance.hud = this;
		Boss.Instance.hud = this;
		StartGame ();
	}


	//Update points label text
	public void UpdatePoints(){

		points.text = "Points: " + Player.Instance.Points;

	}
	//Update health label text
	public void UpdateHealth(){
		
		health.text = "Health: " + Player.Instance.Health;
	}

	//Update bosshp label text
	public void UpdateBoss(){

		bosshp.text = "Boss HP: " + Boss.Instance.Health;
	}
	//Game Over 
	public void GameOver(){

		//Hide  health, points and win labels
		points.gameObject.SetActive(false);
		health.gameObject.SetActive(false);
		win.gameObject.SetActive(false);
		bosshp.gameObject.SetActive(false);
		startBtn.gameObject.SetActive (false);

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

	public void Win(){

		//Hide  health and points labels
		points.gameObject.SetActive(false);
		health.gameObject.SetActive(false);

		gameOverLabel.gameObject.SetActive(false);
		startBtn.gameObject.SetActive (false);

		boss.gameObject.SetActive (false);
		bosshp.gameObject.SetActive(false);
		//Disable player
		player.gameObject.SetActive(false);
		//Display win label
		win.gameObject.SetActive(true);


		

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
		Boss.Instance.Health = 5;

		//Show player
		player.gameObject.SetActive(true);


		//Hide "Gamer Over", restart button and high score
		gameOverLabel.gameObject.SetActive(false);
		restartBtn.gameObject.SetActive (false);
		highScore.gameObject.SetActive (false);
		startBtn.gameObject.SetActive (false);
		//Hide win label
		win.gameObject.SetActive(false);



		//Hide boss
		boss.gameObject.SetActive(false);
		bosshp.gameObject.SetActive(false);

	}
	//Start Game, hide every UI except the start button
	public void StartGame(){

		//Show  points and health
		points.gameObject.SetActive(false);
		health.gameObject.SetActive(false);
		player.gameObject.SetActive(false);
		gameOverLabel.gameObject.SetActive(false);
		restartBtn.gameObject.SetActive (false);
		highScore.gameObject.SetActive (false);
		startBtn.gameObject.SetActive (true);
		win.gameObject.SetActive(false);
		boss.gameObject.SetActive(false);
		bosshp.gameObject.SetActive(false);

	}


	//Display Boss
	public void ActiveBoss(){

		boss.gameObject.SetActive(true);
		bosshp.gameObject.SetActive(true);
	}
}
