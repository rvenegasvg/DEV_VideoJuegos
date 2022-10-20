using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leerdropdown : MonoBehaviour
{
    public TMPro.TMP_Dropdown dropdown;

    public void getDataDowndown()
    {
        Debug.Log("Valor Dropdown: "+dropdown.options[dropdown.value].text);
    }
    
}
