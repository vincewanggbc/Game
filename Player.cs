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

public class Player {
	
	private int _points = 0;
	private int _health = 5;

	public HUDController hud;
	public PowerController power;



	private static Player _instance = null;
	public static Player Instance{

		get{ 
			if (_instance == null) {

				_instance = new Player ();
			}
			return _instance;
		}
	}

	private const string key = "HIGH_SCORE";
	private Player(){

		if (PlayerPrefs.HasKey (key))
			_highScore = PlayerPrefs.GetInt (key);

	}

	public int Points{
		get{ 
			return _points;
		}

		set{ 
			_points = value;
			HighScore = _points;
			//Update points in UI
			hud.UpdatePoints();
			//Whenever player get 100 points, create a power object for player collect
			if ((value >= 100) && (value % 100 == 0)) {
				power.Reset ();
			

			}
			//Display boss when point over 300
			if (value >= 300&&value<=315) {

				hud.ActiveBoss ();			
			}
		}
	}

	private int _highScore = 0;



	public int HighScore{

		get{
			return _highScore;
		}

		set{
			if(value > _highScore)
				_highScore = value;
			PlayerPrefs.SetInt(key,_highScore);
		}
	}


	public int Health{
		get{ 
			return _health;
		}

		set{ 
			_health = value;

			//Update health in UI
			hud.UpdateHealth();
			//If lives equal to 0, game over
			if (_health <= 0)
				hud.GameOver();
		}
	}
}
