using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingPlatformGoal : MonoBehaviour
{
	public float useSpeed;
	public float directionSpeed = 9.0f;
	float origY;
	public float distance = 10.0f;
	public SceneSwitchRev scene;
	private int counter;
	public Sprite sprite2;
	private bool changed = false;
	private int frames = 0;
	public GameObject player;

	private SpriteRenderer render;

	// Use this for initialization
	void Start ()
	{
		render = GetComponent<SpriteRenderer> ();
		origY = transform.position.y;
		useSpeed = directionSpeed;
	}

	// Update is called once per frame
	void Update ()
	{
		if(scene.finished == false){
		if(origY - transform.position.y > distance)
		{
			useSpeed = directionSpeed; //flip direction
		}
		else if(origY - transform.position.y < -distance)
		{
			useSpeed = -directionSpeed; //flip direction
		}
		transform.Translate(0,useSpeed*Time.deltaTime,0);
		}

		if(scene.finished == true){
			if (changed == false) {
				changed = true;
				render.sprite = sprite2;
				player.GetComponent<SpriteRenderer> ().sprite = null;
				//StartCoroutine (WaitSeconds ());
			}
			if(useSpeed < 0){useSpeed = -useSpeed;}
			frames += 1;
			if (frames > 35) {
				counter += 1;
				transform.Translate (0, useSpeed * Time.deltaTime * counter, 0);
			}
			if (frames > 85) {
				SceneManager.LoadScene (scene.sceneToLoad);
			}
		}
	}

	/*public void Rise ()
	{
		if (useSpeed < 0) {
			useSpeed = -useSpeed;
		}

		while (true) {
			transform.Translate (0, useSpeed * Time.deltaTime, 0);
		}

	}*/

	IEnumerator WaitSeconds(){
		int test = 2 + 3;
		yield return new WaitForSecondsRealtime(3);
	}
}
