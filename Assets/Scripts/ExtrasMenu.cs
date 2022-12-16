using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrasMenu : MonoBehaviour
{
    public GameObject Menu;
    public void OnClickedButton()
    {
        Menu.SetActive(!Menu.activeSelf);
    }
}
