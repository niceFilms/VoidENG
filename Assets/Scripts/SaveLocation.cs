using UnityEngine;

public class SaveLocation : MonoBehaviour
{
	public Setandloadpos Player;
	public health alsoPlayer;
	public GameObject SaveText;
	public SaveData SaveData;
	bool InTrigger;

	// The alpha value of the object at the start and end of the transition
	float startAlpha = 0;
	float endAlpha = 1;

	// The duration of the transition
	float transitionDuration = 0.1f;

	// The elapsed time since the transition started
	float elapsedTime = 0;

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			elapsedTime = 0;
			InTrigger = true;
		}
	}
	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player")
		{
			elapsedTime = 0;
			InTrigger = false;
		}
	}
	void Update ()
	{
		if (InTrigger)
		{
				alsoPlayer.Health = 1;
				SaveData.save = true;

				// Increment the elapsed time
				elapsedTime += Time.deltaTime;

				// Calculate the object's alpha value based on the elapsed time
				float alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / transitionDuration);

				// Set the canvas' alpha value
				SaveText.GetComponent<CanvasGroup>().alpha = alpha;
		}
		else
		{
			// Increment the elapsed time
			elapsedTime += Time.deltaTime;

			// Calculate the object's alpha value based on the elapsed time
			float alpha = Mathf.Lerp(endAlpha, startAlpha, elapsedTime / transitionDuration);

			// Set the canvas' alpha value
			SaveText.GetComponent<CanvasGroup>().alpha = alpha;
		}
	}
}
