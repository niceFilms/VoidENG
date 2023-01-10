using UnityEngine;

public class SwitchSceneToSavedScene : MonoBehaviour
{
    public SaveData inv;
    void Awake()
    {
        Time.timeScale = 1.0f;
		UnityEngine.SceneManagement.SceneManager.LoadScene(inv.inventory.Level);
	}
}
