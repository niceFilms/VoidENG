using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REMHEALTH : MonoBehaviour
{
	public health player;
	public float amount;
	void OnTriggerEnter (Collider c)
	{
		if (c.tag == "Player")
		{
			player.Health += amount;
		}
	}
}