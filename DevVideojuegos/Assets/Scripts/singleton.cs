using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleton : MonoBehaviour
{
    public static singleton current;
    public int segundos = 0;
    public int maxSegundos;


    private void Awake()
    {
        if (current == null)
        {
            DontDestroyOnLoad(gameObject);
            current = this;
        }
        else
        {
            if (current != this)
            {
                Destroy(gameObject);
            }
        }


    }

    IEnumerator Waitwhile(int tiempo)
    {
        Debug.Log("Waiting for prince/princess to rescue me...");
        yield return new WaitWhile(() => segundos < tiempo);
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


    public void LanzarCorrutina()
    {
        StartCoroutine(Contar());
        StartCoroutine(Waitwhile(maxSegundos));
    }

}
