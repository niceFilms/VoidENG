using UnityEngine;
public class Setandloadpos : MonoBehaviour
{
	public SaveData inv;
	public Transform trans;
	
	// Start is called before the first frame update
	void Start ()
	{
		trans.position = inv.inventory.Position;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		if ((Time.time % 10) >= 9)
		{
			inv.inventory.Position = trans.position;
		}
		if (Input.GetKey(KeyCode.Escape))
		{
			inv.inventory.Position = new Vector3(0, (float)7.31, 0);
			Application.Quit();
		}
	}
}
