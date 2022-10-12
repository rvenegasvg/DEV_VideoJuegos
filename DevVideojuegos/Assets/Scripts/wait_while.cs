using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wait_while : MonoBehaviour
{
    public int segundos;


    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        Debug.Log("Waiting for prince/princess to rescue me...");
        yield return new WaitWhile(() => segundos < 10);
        Debug.Log("Finally I have been rescued!");
    }


    IEnumerator Contar()
    {

        for (int i = 0; i < 10; i++)
        {
            segundos++;
            yield return new WaitForSeconds(1f);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            StartCoroutine(Contar());
    }

}
