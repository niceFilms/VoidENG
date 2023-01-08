using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class StaminaSlider : MonoBehaviour
{
	public Slider Stanim;
	public PlayerMovement PlayersStanima;
	public GameObject FR;
	public void Update ()
	{
		Stanim.value = PlayersStanima.Stamina/100;
		float a = Stanim.value;
		a *= 100;
		string b = a.ToString("0");
		if (b == "0")
		{
			FR.SetActive(false);
		}
		else
		{
			FR.SetActive(true);
		}
	}
}
