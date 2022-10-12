using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio_escena : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //SceneManager.LoadScene("escena siguiente");
            SceneManager.LoadScene("singletontest_siguiente");
        }
    }
}
