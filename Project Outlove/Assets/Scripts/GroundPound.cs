﻿using UnityEngine;
using System.Collections;

public class GroundPound : MovementActions {

	public float poundSpeed = -300f;
	public bool pounding = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var canPound = inputState.GetButtonValue (inputButtons [0]);
		var holdTime = inputState.GetButtonHoldTime (inputButtons [0]);

		if (collisionState.standing == false) {
			if (canPound && holdTime < .1f) {
				OnPound ();
			}
		} else { pounding = false;
		}

	}

	protected virtual void OnPound(){
		var vel = body2d.velocity;
		pounding = true;


		body2d.velocity = new Vector2 (vel.x, poundSpeed);
		
	}
}
