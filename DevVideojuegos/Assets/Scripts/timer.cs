using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float timeLeft = 30.0f;
    public bool termino = false;

    //IEnumerator tiempo()
    //{

    //    for (int i = 0; i < 60; i++)
    //    {
    //        Debug.Log("el tiempo es " + i);
    //        yield return new WaitForSeconds(1);
    //    }

    //}



    private void Start()
    {
       // StartCoroutine(tiempo());
    }

    private void Update()
    {


        if (!termino)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                GameOver();
            }
        }
        else { Debug.Log("el proceso dejo de contar el tiempo"); }
     }

    void GameOver()
    {
        Debug.Log("el juego termino...");
        termino = true;
    }
    
}
