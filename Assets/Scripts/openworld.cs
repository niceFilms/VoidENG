using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class openworld : MonoBehaviour
{
	public GameObject Section;
	public Transform trns;
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

	[System.Obsolete]
	public void FixedUpdate ()
	{
		StartCoroutine(OBJect());
	}
		IEnumerator OBJect()
	{
		if (touched)
		{
			if (spwn)
			{
				spwn = false;
				GameObject OTJ = GameObject.Instantiate(Section, new Vector3(trns.position.x, trns.position.y, trns.position.z), Quaternion.identity);
				OTJ.transform.parent = trns.transform;
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

