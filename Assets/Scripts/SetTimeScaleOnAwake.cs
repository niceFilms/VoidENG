using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTimeScaleOnAwake : MonoBehaviour
{
    public float value = 1f;
    void Awake()
    {
		Time.timeScale = value;
	}
}
