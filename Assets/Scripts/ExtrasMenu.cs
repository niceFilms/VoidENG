using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrasMenu : MonoBehaviour
{
    public GameObject Menu;
    public bool setval;
    public bool val;
    public void OnClickedButton()
    {
        Menu.SetActive(!Menu.activeSelf);
        if (setval)
        {
            Menu.SetActive(val);
        }
    }
}
