using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFullScreenMode : MonoBehaviour
{
    public bool fullscreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Screen.fullScreen = fullscreen; 
	}
}
