using UnityEngine;
using System.Collections;

public class Jump : MovementActions {

	public float jumpSpeed = 200f;
    private AudioSource source;
    public AudioClip clip;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}

    // void Awake()
    // {

    // }
	
	// Update is called once per frame
	void Update () {
		var canJump = inputState.GetButtonValue (inputButtons [0]);
		var holdTime = inputState.GetButtonHoldTime (inputButtons [0]);

		if (collisionState.standing) {
			if(canJump && holdTime < .1f){
				OnJump ();
			}
		}

	}

	protected virtual void OnJump(){
		var vel = body2d.velocity;

		body2d.velocity = new Vector2 (vel.x, jumpSpeed);
        source.PlayOneShot(clip, 1);
		
	}
}
