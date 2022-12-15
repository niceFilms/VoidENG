using UnityEngine;
using UnityEngine.SceneManagement;

public class Setandloadpos : MonoBehaviour
{
	public SaveData inv;
	public Transform trans;
	
	// Start is called before the first frame update
	void Start ()
	{
		try { trans.position = inv.inventory.Position; }
		catch { }
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		if ((Time.time % 10) >= 9)
		{
			try{ inv.inventory.Position = trans.position; }
			catch { }
			
		}
		if (Input.GetKey(KeyCode.Escape))
		{
			try { inv.inventory.Position = new Vector3(0, (float)7.31, 0); }
			catch { }
			Application.Quit();
		}
	}
}
