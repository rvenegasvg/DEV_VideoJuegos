using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leerinput : MonoBehaviour
{

    public  TMPro.TMP_InputField inputField;

    public void getData()
    {
        string cadena = "";
        cadena = inputField.text;
        Debug.Log(cadena);

        if (string.IsNullOrEmpty(cadena))
        {
            PlayerPrefs.SetString("nombre", cadena);
            Debug.Log("el nombre en el playerprefs es: " + PlayerPrefs.GetString("nombre"));
        }
        else
        {
            Debug.Log("no guardo ningun dato");
        }
       

       
    }


}
