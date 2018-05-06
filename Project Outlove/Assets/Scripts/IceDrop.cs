using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDrop : MonoBehaviour {

	private bool active;
	public float fallSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(active==true){
            transform.Translate(0, fallSpeed * Time.deltaTime, 0);
		}
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        active=true;
    }
}
