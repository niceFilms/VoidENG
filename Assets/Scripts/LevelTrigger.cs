using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour
{
	public string nextSceneName;
	public SaveData inv;
	public Vector3 startpos;

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player")
		{
			inv.inventory.Position = startpos;
			inv.inventory.Level = nextSceneName;
			inv.SaveToJson();
			UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
		}
	}
}
