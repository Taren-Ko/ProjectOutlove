using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnGoal : MonoBehaviour {

	public SceneSwitchRev goal;
	private bool changed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (goal.finished == true && changed == false) {
			changed = true;
			SpriteRenderer render = GetComponent<SpriteRenderer> ();
			render.sprite = null;
	}
}
}
