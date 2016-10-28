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

public class BossMissileController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Vector2 _currentPosition;
	private Transform _transform;


	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = transform.position;


	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;
		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;

	}



	//When collide with player
	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "player") {

			Player.Instance.Health -= 1;

			Destroy (gameObject);
		}

	}

}
