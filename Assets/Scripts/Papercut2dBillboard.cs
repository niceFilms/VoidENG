using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Papercut2dBillboard : MonoBehaviour
{
	public bool useLerp;
	[SerializeField]
	public float lerpSpeed;

	void OnValidate ()
	{
		if (!useLerp)
		{
			lerpSpeed = 0;
		}
	}

	void Update ()
	{
		if (useLerp)
		{
			// Use Lerp to smoothly rotate towards the camera's rotation
			transform.rotation = Quaternion.Lerp(transform.rotation, Camera.main.transform.rotation, lerpSpeed * Time.deltaTime);
		}
		else
		{
			// Use regular rotation assignment to instantly rotate towards the camera's rotation
			transform.rotation = Camera.main.transform.rotation;
		}
	}
}
