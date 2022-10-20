using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leerguardar : MonoBehaviour
{

    public Toggle toggle;


    public void leerToggle()
    {
        if (toggle.isOn)
        {
            Debug.Log("usara la escena de dia");
        }
        else
        {
            Debug.Log("usara la escena de noche");
        }
            

    }


}
