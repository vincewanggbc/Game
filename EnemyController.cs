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

public class EnemyController : MonoBehaviour {


	[SerializeField]
	private float speedX;
	//Value for the random position
	private float miny = -4f;
	private float maxy = 4f;
	private float minx = 13f;
	private float maxx = 18f;

	private Vector2 _currentPosition;
	private Transform _transform;


	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;

	}

	// Update 
	void FixedUpdate () {

		_currentPosition -= new Vector2 (speedX, 0);

		_transform.position = _currentPosition;

		if (_currentPosition.x <= -20) {
			Reset ();
		}
	}

	//Reset the enemy by random position
	public void Reset(){

		float ypos = Random.Range (miny, maxy);
		float xpos = Random.Range (minx, maxx);
		_currentPosition = new Vector2 (xpos, ypos);
		_transform.position = _currentPosition;
	}
}
