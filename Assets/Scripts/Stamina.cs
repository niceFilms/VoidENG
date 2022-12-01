using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stamina : MonoBehaviour 
{
    public TextMeshProUGUI Stanim;
    public PlayerMovement PlayersStanima;
        void Update()
    {
        Stanim.SetText ("Stamina: " + PlayersStanima.Stamina.ToString("0") + "%");
        //.ToString("0")
    }
}
