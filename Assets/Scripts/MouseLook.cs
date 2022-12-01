using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

	public float mS = 100f;
	public Transform playerBody;
	float xrotation;

	// Start is called before the first frame update
	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update ()
	{
		float mouseX = Input.GetAxis("Mouse X") * mS * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mS * Time.deltaTime;

		xrotation -= mouseY;
		xrotation = Mathf.Clamp(xrotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);

		playerBody.Rotate(Vector3.up * mouseX);
	}
}