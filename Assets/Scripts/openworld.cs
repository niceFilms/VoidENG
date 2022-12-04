using UnityEngine;

public class openworld : MonoBehaviour
{
	public GameObject Section;
	public Transform trns;
	bool touched;
	bool spwn;
	Object OTJ;

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

	public void Update ()
	{
		if (touched)
		{
			if (spwn)
			{
				spwn = false;
				Object OTJ = GameObject.Instantiate(Section, new Vector3(trns.position.x, trns.position.y, trns.position.z), Quaternion.identity);
			}
		}

		if (!touched)
		{
			Destroy(OTJ);
		}
	}
}