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

public class PointsController : MonoBehaviour {

	[SerializeField]
	private float speedY;
	[SerializeField]
	private float speedX;

	private float minx = 0f;
	private float maxx = 11f;

	private Vector2 _currentPosition;
	private Transform _transform;


	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;

	}

	// Update is called once per frame
	void FixedUpdate () {

		_currentPosition -= new Vector2 (speedX, speedY);

		_transform.position = _currentPosition;
		//Make enough time for reseting
		if (_currentPosition.y <= -30) {
			Reset ();
		}
	}

	//Reset points with x.position between 0 - 11
	public void Reset(){
		
		float xpos = Random.Range (minx, maxx);
		_currentPosition = new Vector2 (xpos, 20f);
		_transform.position = _currentPosition;
	}
}
