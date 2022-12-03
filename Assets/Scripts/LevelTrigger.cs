using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour
{
	public string sceneName;
	public SaveData inv;
	public Vector3 startpos;

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player")
		{
			inv.inventory.Position = startpos;
			inv.SaveToJson();
			UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
		}
}
}
