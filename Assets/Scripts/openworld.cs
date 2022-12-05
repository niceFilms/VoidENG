using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class openworld : MonoBehaviour
{
	public GameObject Section;
	public Transform trns;
	public Vector3 offset;
	public Quaternion rotation;
	public bool test;
	bool touched;
	bool spwn;
	GameObject OTJ;

	public void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag("Player"))
		{
			if (!touched)
			{
				touched = true;
				spwn = true;
			}
		}
	}
	public void OnTriggerExit (Collider other)
	{
		if (other.CompareTag("Player"))
		{
			if (touched)
			{
				touched = false;
			}
		}
	}
	public void FixedUpdate ()
	{
		if (!test)
		{
			StartCoroutine(OBJect());
		}
		else
		{
			GameObject OTJ = GameObject.Instantiate(Section, new Vector3(trns.position.x + offset.x, trns.position.y + offset.y, trns.position.z + offset.z), Quaternion.identity);
			OTJ.transform.parent = trns.transform;
			OTJ.transform.rotation = rotation;
			Destroy(OTJ, 0.02f);
		}
	}
		IEnumerator OBJect()
	{
		if (touched)
		{
			if (spwn)
			{
				spwn = false;
				GameObject OTJ = GameObject.Instantiate(Section, new Vector3(trns.position.x + offset.x, trns.position.y + offset.y, trns.position.z + offset.z), Quaternion.identity);
				OTJ.transform.parent = trns.transform;
				OTJ.transform.rotation = rotation;
				while(touched == true)
				{
					yield return new WaitForSeconds(0.02f);
				}
				if (!touched)
				{
					Destroy(OTJ);
				}
			}
		}
		
	}
}

