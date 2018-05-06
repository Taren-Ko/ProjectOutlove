using UnityEngine;
using System.Collections;

public class StickToWall : MovementActions {

	public bool onWallDetected;

	protected float defaultGravityScale;
	protected float defaultDrag;

	void Start () {
		
	}
	protected virtual void Update () {

		if (collisionState.onWall) {
			if(!onWallDetected){
				onWallDetected = true;
			}

		} else {
			if(onWallDetected){
				onWallDetected = false;
			}

		}

	}
}
