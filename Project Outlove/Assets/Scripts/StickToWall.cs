using UnityEngine;
using System.Collections;

public class StickToWall : MovementActions {

	public bool WallTrigger;
	void Start () {
		
	}
	protected virtual void Update () {

		if (collisionState.onWall) {
			if(!WallTrigger){
				WallTrigger = true;
			}

		} else {
			if(WallTrigger){
				WallTrigger = false;
			}

		}

	}
}
