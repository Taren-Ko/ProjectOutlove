using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAnimation : MonoBehaviour {

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
			animator.SetInteger("MainAnimationState", 1);
		}
		else {
			animator.SetInteger("MainAnimationState", 0);	
		}
	}
}
