using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class acciones : MonoBehaviour
{

    public void pasarescena()
    {
        SceneManager.LoadScene("escena1");
    }
}
