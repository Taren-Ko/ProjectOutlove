﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlatformVertical : MonoBehaviour {

	public LeverSprite lever;
	private float useSpeed;
	public float directionSpeed = 9.0f;
	float origY;
	public float distance = 10.0f;

	// Use this for initialization
	void Start () {
		origY = transform.position.y;
		useSpeed = directionSpeed;
	}
	
	// Update is called once per frame
	void Update () {

		if (lever.switchOn == true) {
			if(origY - transform.position.y > distance)
			{
				useSpeed = directionSpeed; //flip direction
			}
			else if(origY - transform.position.y < -distance)
			{
				useSpeed = -directionSpeed; //flip direction
			}
			transform.Translate(0,useSpeed*Time.deltaTime,0);
		}
			
	}
}
