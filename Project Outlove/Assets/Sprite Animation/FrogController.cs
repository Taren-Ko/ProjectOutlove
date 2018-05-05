using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		//put code to change FrogAnimationState to 0 if walking, 1 if jumping, and 2 if climbing
		//animator.setInteger("FrogAnimationState", 0);

	}
}
	