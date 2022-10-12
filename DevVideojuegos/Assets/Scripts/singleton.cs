using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleton : MonoBehaviour
{
    public static singleton current;
   

    private void Awake()
    {
        if(current == null)
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
}
