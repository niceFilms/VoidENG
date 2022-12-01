using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioSource source;
 
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
            source.Play();
    }
}
