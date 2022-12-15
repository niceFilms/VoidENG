using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCursor : MonoBehaviour
{

    public CursorLockMode mode;

    // Update is called once per frame
    void Update()
    {
		Cursor.lockState = mode;
	}
}
