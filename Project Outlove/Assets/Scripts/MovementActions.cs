using UnityEngine;
using System.Collections;

public abstract class MovementActions : MonoBehaviour {

	
	public MonoBehaviour[] dissableScripts;
	protected InputState inputState;
	protected Rigidbody2D body2d;
	protected CollisionState collisionState;
	public Buttons[] inputButtons;

	protected virtual void Awake(){
		inputState = GetComponent<InputState> ();
		body2d = GetComponent<Rigidbody2D> ();
		collisionState = GetComponent<CollisionState> ();
	}
}
