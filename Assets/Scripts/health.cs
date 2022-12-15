using UnityEngine;

public class health : MonoBehaviour
{
	public float Health;
	public string CurrentScene;
	public float olHealth = 100;
	public bool test = true;
	private void Update ()
	{
		if (test)
		{
			Health = (olHealth);
			Health /= 100;
		}
		if (Health <= 0)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("Dead");
		}
		Health += 0.2f * Time.deltaTime;
		Health = Mathf.Clamp(Health, 0, 1);
	}
	public void Hurt (float Amount)
	{
		Health -= Amount;
	}
}
