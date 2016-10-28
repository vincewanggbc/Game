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

public class PlaneController : MonoBehaviour {

	//Vertical speed and Horizontal speed
	[SerializeField]
	private float speedY;
	[SerializeField]
	private float speedX;

	[SerializeField]
	GameObject missile = null;

	private Vector2 _currentPosition;
	private Transform _transform;
	private float _playerInputY;
	private float _playerInputX;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;

	}

	// Update position according to the input
	void FixedUpdate () {


		_playerInputY = Input.GetAxis ("Vertical");
		_playerInputX = Input.GetAxis ("Horizontal");
		if (_playerInputY > 0)
			_currentPosition += new Vector2 (0, speedY);
		if (_playerInputY < 0)
			_currentPosition -= new Vector2 (0, speedY);

		if (_playerInputX > 0)
			_currentPosition += new Vector2 (speedX, 0);
		if (_playerInputX < 0)
			_currentPosition -= new Vector2 (speedX, 0);
		CheckBound ();
		_transform.position = _currentPosition;


		if (Input.GetKeyDown (KeyCode.J)) {

			GameObject mi = Instantiate (missile);
			mi.transform.position = new Vector2 ((_transform.position.x+1.6f), (_transform.position.y+0.3f)); 
		
		}


	}

	//method keep the plane in the camera
	private void CheckBound(){

		if (_currentPosition.y > 5.8f)
			_currentPosition.y = 5.8f;
		if (_currentPosition.y < -6.3f)
			_currentPosition.y = -6.3f;

		if (_currentPosition.x > 10.5f)
			_currentPosition.x = 10.5f;
		if (_currentPosition.x < -10.5f)
			_currentPosition.x = -10.5f;
	}

	public void PowerUpSpeed(){
	
		speedX += 0.02f;
		speedY += 0.01f;
	}
	
	}

