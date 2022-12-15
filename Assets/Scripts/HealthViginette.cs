using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class HealthViginette : MonoBehaviour
{

    public Transform OBJ;
    private Image img;
    public health Health;
    float hedhs;

	private void Start ()
	{
		img = GetComponent<Image>();
	}

	// Update is called once per frame
	void Update()
    {
        hedhs = Health.Health;
        hedhs = Mathf.Clamp(hedhs, 0, 1);
        hedhs = -hedhs;
        hedhs -= 1;
        OBJ.localScale = new Vector3(hedhs, hedhs, hedhs);
        if (Health.Health >= 0.90)
        {
            img.enabled = false;
        }
        else
        {
			img.enabled = true;
		}
    }
}
