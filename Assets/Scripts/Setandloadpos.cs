using UnityEngine;
using UnityEngine.SceneManagement;

public class Setandloadpos : MonoBehaviour
{
	public SaveData inv;
	public Transform trans;
	public PlayerMovement movement;
	public bool autosave;
	
	// Start is called before the first frame update
	void Start ()
	{
		try { trans.position = inv.inventory.Position; }
		catch { }
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		if (autosave)
		{
			try
			{
				if (movement.isGrounded)
				{
					if ((Time.time % 10) >= 9)
					{
						try { inv.inventory.Position = trans.position; }
						catch { }

					}
				}
			}
			catch { }
		}
	}
}
