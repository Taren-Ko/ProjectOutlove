using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public Camera mainCamera;
	public GroundPound player;
	private Vector3 camPos;

	float shakeAmount = 0;

	void Awake()
	{
		if (mainCamera == null) {
			mainCamera = Camera.main;
		}
	}

	void Update()
	{

		if (player.pounding == true) {
			Shake(0.3f, 0.5f);
		}
		if (Input.GetKeyDown(KeyCode.T))
		{
			Shake(0.3f, 1f);
		}
	}

	public void ShakeStart()
	{
		camPos = mainCamera.transform.position;
		if (shakeAmount > 0)
		{
			Vector3 campos = mainCamera.transform.position;
			float shakeAmountX = Random.value * shakeAmount * 2 - shakeAmount;
			float shakeAmountY = Random.value * shakeAmount * 2 - shakeAmount;

			campos.x += shakeAmountX;
			campos.y += shakeAmountY;

			mainCamera.transform.position = campos;
		}
	}


	void ShakeEnd()
	{
		CancelInvoke("ShakeStart");
		mainCamera.transform.position = camPos;

	}

	public void Shake(float amount, float length)
	{
		shakeAmount = amount;
		InvokeRepeating("ShakeStart", 0, 0.01f);
		Invoke ("ShakeEnd", length);
	}


}
