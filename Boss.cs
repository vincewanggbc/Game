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

public class Boss {

	public HUDController hud;
	private int _health = 5;

	private static Boss _instance = null;
	public static Boss Instance{

		get{ 
			if (_instance == null) {

				_instance = new Boss ();
			}
			return _instance;
		}
	}


	private Boss(){


	}




	public int Health{
		get{ 
			return _health;
		}

		set{ 
			_health = value;

			hud.UpdateBoss ();
			//if boss hp less than 0 ,win.
			if (_health <= 0)
				hud.Win();
		}
	}
}
