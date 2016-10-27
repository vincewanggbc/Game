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

public class SkyController : MonoBehaviour {


	[SerializeField]
	private float speed;

	private Vector2 _currentPosition;
	private Transform _transform;

	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;
		Reset ();
	
	}
	
	// Update is called once per frame
	void Update () {

		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -13.5)
			Reset ();
	
	}

	//Reset the position
	private void Reset(){

		_currentPosition = new Vector2 (13.5f, 0);
		_transform.position = _currentPosition;
	}
}
