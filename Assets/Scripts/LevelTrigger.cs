using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour
{
    public string sceneName;
 
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
