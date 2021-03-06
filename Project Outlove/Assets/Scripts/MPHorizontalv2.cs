using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPHorizontalv2 : MonoBehaviour {

	public LeverSprite lever;
	private float useSpeed;
	public float directionSpeed = 11.0f;
	float origX;
	public float distance = 30.0f;
	private GameObject target = null;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		origX = transform.position.x;
		useSpeed = directionSpeed;
	}
	
	// Update is called once per frame
	void Update () {

		if (lever.switchOn == true) {
			if (origX - transform.position.x < 0) {
				useSpeed = directionSpeed; //flip direction
			} else if (origX - transform.position.x > 2 * distance) {
				useSpeed = -directionSpeed; //flip direction
			}
			transform.Translate (-useSpeed * Time.deltaTime, 0, 0);
		}
	}
	
	void OnTriggerStay2D(Collider2D collision){
		target = collision.gameObject;
		offset = target.transform.position - transform.position;
	}

	void OnTriggerExit2D(Collider2D collision){
		target = null;
	}

	void LateUpdate(){
		if (target != null) {
			target.transform.position = transform.position + offset;
		}
	}
	
	
}
