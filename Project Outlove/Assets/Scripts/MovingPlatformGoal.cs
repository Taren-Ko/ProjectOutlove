using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformGoal : MonoBehaviour
{
	public float useSpeed;
	public float directionSpeed = 9.0f;
	float origY;
	public float distance = 10.0f;
	public SceneSwitch scene;

	// Use this for initialization
	void Start ()
	{
		origY = transform.position.y;
		useSpeed = directionSpeed;
	}

	// Update is called once per frame
	void Update ()
	{
		if(scene.finished == false){
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

		if(scene.finished == true){
			if(useSpeed < 0){useSpeed = -useSpeed;}
			transform.Translate(0,useSpeed*Time.deltaTime,0);
		}
	}

	/*public void Rise ()
	{
		if (useSpeed < 0) {
			useSpeed = -useSpeed;
		}

		while (true) {
			transform.Translate (0, useSpeed * Time.deltaTime, 0);
		}

	}*/
}
