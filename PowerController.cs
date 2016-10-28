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

public class PowerController : MonoBehaviour {

	[SerializeField]
	private float speedY;

	private Vector2 _currentPosition;
	private Transform _transform;


	// Use this for initialization
	void Start () {
		Player.Instance.power = this;
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;

	}

	// Update is called once per frame
	void FixedUpdate () {

		_currentPosition -= new Vector2 (0, speedY);

		_transform.position = _currentPosition;

	}

	//Reset points with x.position between 0 - 11
	public void Reset(){

		//display power object
		gameObject.SetActive (true);

		_currentPosition = new Vector2 (0, 10f);
		_transform.position = _currentPosition;
	}
}
