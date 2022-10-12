using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invoke : MonoBehaviour
{
    //void Start()
    //{
    //    Invoke("Print", 5f);
    //}

    //void Print()
    //{
    //    Debug.Log("Method is executed");
    //}

    void Start()
    {
        InvokeRepeating("Print", 2f, 1f);
        StartCoroutine("stop");
        
        StopCoroutine(stop());
    }

    void Print()
    {
        Debug.Log("Method is executed");
    }

    IEnumerator stop()
    {
        yield return new WaitForSeconds(8f);
        CancelInvoke();
    }
}

