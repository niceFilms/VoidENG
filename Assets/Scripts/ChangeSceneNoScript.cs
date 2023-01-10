using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneNoScript : MonoBehaviour
{
	public string nextscene;
	public void OnButtonPress ()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(nextscene);
	}
}
