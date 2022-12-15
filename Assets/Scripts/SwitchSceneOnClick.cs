using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SwitchSceneOnClick : MonoBehaviour
{
	public string nextscene;
	public void OnButtonPress ()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(nextscene);
	}
}
