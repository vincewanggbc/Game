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

public class BossController : MonoBehaviour {

	[SerializeField]
	private float speed;

	[SerializeField]
	GameObject missile = null;

	private Transform _transform;
	private Vector2 _currentPosition;


	private int direction = 1;


	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}


	void FixedUpdate () {

		_currentPosition = _transform.position;
		_currentPosition -= new Vector2 (0, speed*direction);
		_transform.position = _currentPosition;


		//Let boss keep move between Y position -3 to 3
		if (_currentPosition.y <= -3) {
			Reset ();
		}
		if (_currentPosition.y >=3) {
			Reset ();
		}

		//Boss shoot
		if (_currentPosition.y <=0.04&&_currentPosition.y>=-0.04 ) {

		
			GameObject mi = Instantiate (missile);
			mi.transform.position = new Vector2 ((_transform.position.x-2.8f), (_transform.position.y+1.9f)); 
		
		}
	}

	public void Reset(){


		direction = -direction;
		_currentPosition = new Vector2 (9.5f, 3f*direction);
		_transform.position = _currentPosition;
	}


}
