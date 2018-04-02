using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class LeverSprite : MonoBehaviour {

	//public Sprite sprite1;
	//public Sprite sprite2;

	private SpriteRenderer spriteRenderer; 
	private bool canFlip;
	public bool switchOn;

	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		//if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			//spriteRenderer.sprite = sprite1; // set the sprite to sprite1
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player")){
			canFlip = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player")){
			canFlip = false;
		}
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Z) && canFlip)
			{
			if (spriteRenderer.flipX == true) {
				spriteRenderer.flipX = false;
				switchOn = false;
			} else {
				spriteRenderer.flipX = true;
				switchOn = true;
			}
		}
	}

}