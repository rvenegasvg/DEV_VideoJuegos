using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    public void FadeSinCorrutina()
    {
        
         for (float f = 1f; f >= 0; f -= 0.1f)
         {
             Color c = GetComponent<MeshRenderer>().material.color;
             c.a = f;
             GetComponent<MeshRenderer>().material.color = c;
         }
        
    }

    IEnumerator FadeConCorrutina()
    {
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            Color c = GetComponent<MeshRenderer>().material.color;
            c.a = f;
            GetComponent<MeshRenderer>().material.color = c;
            yield return new WaitForSeconds(0.3f);
           // yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("fade SIN corrutina");
            FadeSinCorrutina();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("fade CON corrutina");
            StartCoroutine(FadeConCorrutina());
        }
    }
}
