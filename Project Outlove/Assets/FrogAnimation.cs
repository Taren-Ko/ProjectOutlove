using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogAnimation : MovementActions {

	private Animator animator;

	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		var vertical = Input.GetAxis ("Vertical");

		if (Input.GetKey("c"))
		{
			animator.SetInteger("FrogAnimationState", 1);
		}
		else if (collisionState.onWall)
		{
			animator.SetInteger("FrogAnimationState", 2);
		}
		else {
			animator.SetInteger("FrogAnimationState", 0);	
		}
	}
}
