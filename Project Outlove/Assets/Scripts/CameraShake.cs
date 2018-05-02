using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public Camera mainCamera;

	float shakeAmount = 0;

	void Awake()
	{
		if(mainCamera == null)
			mainCamera = Camera.main;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.T))
		{
			Shake(0.3f, 1f);
		}
	}

	void ShakeStart()
	{
		if (shakeAmount > 0)
		{
			Vector3 camPos = mainCamera.transform.position;
			float shakeAmountX = Random.value * shakeAmount * 2 - shakeAmount;
			float shakeAmountY = Random.value * shakeAmount * 2 - shakeAmount;

			camPos.x += shakeAmountX;
			camPos.y += shakeAmountY;

			mainCamera.transform.position = camPos;
		}
	}


	void ShakeEnd()
	{
		CancelInvoke("ShakeStart");
		mainCamera.transform.localPosition = Vector3.zero;

	}

	public void Shake(float amount, float length)
	{
		shakeAmount = amount;
		InvokeRepeating("ShakeStart", 0, 0.01f);
		Invoke ("ShakeEnd", length);
	}


}
