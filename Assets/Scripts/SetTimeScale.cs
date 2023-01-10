using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class SetTimeScale : MonoBehaviour
{
	public float value = 1f;
	public bool changeMouse;
	public CursorLockMode mode;
	public void TS()
    {
		Time.timeScale = value;
		if (changeMouse)
		{
			Cursor.lockState = mode;
		}
	}
}
