using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubito : MonoBehaviour {

	Vector3 cubitoTras;  
	float factorVel;
	public int Player;

	// Use this for initialization
	void Start () {
		cubitoTras = new Vector3 (0.0f, 0.0f, 0.0f);
		factorVel = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {



		/*
		Debug.Log ("Delta: " + Time.deltaTime);
		cubitoTras.y = factorVel * Time.deltaTime;
		transform.Translate (cubitoTras);*/
		cubitoTras.x = 0.0f;
		cubitoTras.y = 0.0f;
		cubitoTras.z = 0.0f;

		if (Player == 1) {

			if (Input.GetKey (KeyCode.UpArrow)) {
				cubitoTras.y = factorVel * Time.deltaTime;
				transform.Translate (cubitoTras);
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				cubitoTras.y = -factorVel * Time.deltaTime;
				transform.Translate (cubitoTras);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				cubitoTras.x = factorVel * Time.deltaTime;
				transform.Translate (cubitoTras);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				cubitoTras.x = -factorVel * Time.deltaTime;
				transform.Translate (cubitoTras);
			}
		}

		if (Player == 2) {

			if (Input.GetKey (KeyCode.W)) {
				cubitoTras.y = factorVel * Time.deltaTime;
				transform.Translate (cubitoTras);
			}
			if (Input.GetKey (KeyCode.S)) {
				cubitoTras.y = -factorVel * Time.deltaTime;
				transform.Translate (cubitoTras);
			}
			if (Input.GetKey (KeyCode.D)) {
				cubitoTras.x = factorVel * Time.deltaTime;
				transform.Translate (cubitoTras);
			}
			if (Input.GetKey (KeyCode.A)) {
				cubitoTras.x = -factorVel * Time.deltaTime;
				transform.Translate (cubitoTras);
			}
		}
	}

	void OnCollisionEnter(Collision col){
	}
}
