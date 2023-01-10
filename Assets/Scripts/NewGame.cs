using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    public SaveData savedata;
    public Vector3 newgamepos;
    public string nextscene;
    // Start is called before the first frame update
    public void OnButtonPress()
    {
        StartCoroutine(newgame());
    }
    IEnumerator newgame ()
    {
        savedata.inventory.Position = newgamepos;
        savedata.inventory.Level = nextscene;
        savedata.inventory.Rotation = new Quaternion(0, 0, 0, 0);
        savedata.SaveToJson();
		yield return new WaitForSeconds(0.1f);
		UnityEngine.SceneManagement.SceneManager.LoadScene("SceneManager");
	}
}
