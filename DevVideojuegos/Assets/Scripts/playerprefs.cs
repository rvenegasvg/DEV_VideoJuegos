using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs : MonoBehaviour
{
    public bool setRut = false;
    // Start is called before the first frame update
    void Start()
    {
        if (setRut)
        {
            Debug.Log("rut seteado");
            PlayerPrefs.SetString("rut", "123456789-0");
        }
        else
        {
            Debug.Log("no hay rut seteado");
        }

        if (PlayerPrefs.HasKey("rut"))
        {
            Debug.Log("la variable es: "+PlayerPrefs.GetString("rut"));
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            PlayerPrefs.SetFloat("numero",1.254f);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.DeleteKey("rut");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log(PlayerPrefs.GetString("rut")+"   "+PlayerPrefs.GetFloat("numero"));
            
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            PlayerPrefs.DeleteAll();
        }
    }


}
