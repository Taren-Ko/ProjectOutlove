using UnityEngine;
using System.Collections;

public class WallClimb : StickToWall {

	public float slideVelocity = 100;

	// Update is called once per frame
	override protected void Update () {
		base.Update ();

		if (onWallDetected) {
			var velY = slideVelocity;

			body2d.velocity = new Vector2(body2d.velocity.x, velY);
		}
	}


}
