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

public class PlaneCollider : MonoBehaviour {


	[SerializeField]
	GameObject explosion = null;

	//When collide with other object
	void OnTriggerEnter2D(Collider2D other){

		//Collide with points
		if (other.gameObject.tag == "point") {

			Player.Instance.Points += 10;

			PointsController po = other.gameObject.GetComponent<PointsController> ();
			//Reset the point object
			if (po != null) {

				po.Reset ();

			}

			AudioSource asrc = other.gameObject.GetComponent<AudioSource> ();
			//Play collection sound
			if (asrc != null) {

				asrc.Play ();
			}

		} //Collide with ememy
		else if (other.gameObject.tag == "enemy") {

			Player.Instance.Health -= 1;
		
			EnemyController en = other.gameObject.GetComponent<EnemyController> ();
			//Show explosion and reset enemy
			if (en != null) {

				GameObject ex = Instantiate (explosion);
				ex.transform.position = en.transform.position;
				en.Reset ();
			
			}
			//
			AudioSource asrc =other.gameObject.GetComponent<AudioSource> ();
			//Play explosion sound
			if (asrc != null) {
				asrc.Play ();
			}

		}

	}
}
