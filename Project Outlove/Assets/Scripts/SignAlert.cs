using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignAlert : MonoBehaviour {

	public Text helpText;
	public string displayText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            setInfoText(1);
        }
    }

	void OnTriggerExit2D(Collider2D other){
		setInfoText(0);
	}

	void setInfoText(int text){
		if(text==1){
			helpText.text=displayText;
		}
		else{
			helpText.text="";
		}
	}
}
