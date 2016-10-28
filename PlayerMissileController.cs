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

public class PlayerMissileController : MonoBehaviour {


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
		_currentPosition += new Vector2 (speed, 0);
		_transform.position = _currentPosition;

	}


	[SerializeField]
	GameObject explosion = null;

	//When collide with other object
	void OnTriggerEnter2D(Collider2D other){
		//Hit enemy
		 if (other.gameObject.tag == "enemy") {

			Player.Instance.Points += 5;

			EnemyController en = other.gameObject.GetComponent<EnemyController> ();
			//Show explosion and reset enemy
			if (en != null) {

				GameObject ex = Instantiate (explosion);
				ex.transform.position = en.transform.position;
				en.Reset ();

			}
		
			AudioSource asrc =other.gameObject.GetComponent<AudioSource> ();
			//Play explosion sound
			if (asrc != null) {
				asrc.Play ();
			}
			Destroy (gameObject);
		}//Hit boss
		else if (other.gameObject.tag == "boss") {

				Boss.Instance.Health -= 1;


	}


}
}