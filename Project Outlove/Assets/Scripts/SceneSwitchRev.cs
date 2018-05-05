using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitchRev : MonoBehaviour{
  public string sceneToLoad;
	public bool finished = false;
void OnTriggerEnter2D (Collider2D collision)
  {
		if (collision.gameObject.tag == "Player") {
			finished = true;

		}
  }
}