using UnityEngine;
using System.Collections;

public class wait_until : MonoBehaviour
{
    public int segundos;


    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        Debug.Log("Waiting for princess to be rescued...");
        yield return new WaitUntil(() => segundos >= 10);
        Debug.Log("Princess was rescued!");
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