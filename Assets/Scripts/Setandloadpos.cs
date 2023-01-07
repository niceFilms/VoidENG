using UnityEngine;

public class Setandloadpos : MonoBehaviour
{
	public SaveData inv;
	public PlayerMovement movement;
	public bool autosave;
	
	// Start is called before the first frame update
	void Start ()
	{
		try { this.transform.position = inv.inventory.Position; }
		catch { }
		try { this.transform.rotation = inv.inventory.Rotation; }
		catch { }
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		try { inv.inventory.Position = this.transform.position; }
		catch { }
		try { inv.inventory.Rotation = this.transform.rotation; }
		catch { }

		if (autosave)
		{
			try
			{
				if (movement.isGrounded)
				{
					if ((Time.time % 10) >= 9)
					{
						
						try { inv.SaveToJson(); }
						catch { }
					}
				}
			}
			catch { }
		}
	}

	public void SavePosition ()
	{
		try { inv.inventory.Position = this.transform.position; }
		catch { }
		try { inv.inventory.Rotation = this.transform.rotation; }
		catch { }
		inv.SaveToJson();
		health Health = GetComponent<health>();
		Health.Health = 1;
	}
}
