using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject gameObject;
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(true);
    }
}
