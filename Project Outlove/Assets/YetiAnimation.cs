using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YetiAnimation : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKey("c"))
		{
			animator.SetInteger("YetiAnimationState", 1);
		}
		else if (Input.GetKey("v"))
		{
			animator.SetInteger("YetiAnimationState", 2);
		}
		else {
				animator.SetInteger("YetiAnimationState", 0);	
		}
	}
}
