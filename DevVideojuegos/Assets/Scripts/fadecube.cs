using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadecube : MonoBehaviour
{

    private void Start()
    {
        // StartCoroutine(FadeConCorrutinaDesaparecer());
        // StartCoroutine(FadeConCorrutinaAparecer());
        StartCoroutine(fade());
    }



    IEnumerator fade()
    {
        yield return FadeConCorrutinaAparecer();
       yield return Mathf.PingPong(Time.time, 8);
        yield return FadeConCorrutinaDesaparecer();
    }
    IEnumerator FadeConCorrutinaDesaparecer()
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
    IEnumerator FadeConCorrutinaAparecer()
    {
        for (float f = 0f; f <= 1; f += 0.1f)
        {
            Color c = GetComponent<MeshRenderer>().material.color;
            c.a = f;
            GetComponent<MeshRenderer>().material.color = c;
            yield return new WaitForSeconds(0.3f);
            // yield return null;
        }
    }
}
