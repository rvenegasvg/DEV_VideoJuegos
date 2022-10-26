using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audiocontroller : MonoBehaviour
{
    public AudioSource audioSource;
    public Toggle toggle;
    public bool onoff = false;


    public void playaudio()
    {
        audioSource.Play();
    }
    public void pauseudio()
    {
        audioSource.Pause();
    }


    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    playaudio();
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    pauseudio();
        //}

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (onoff)
            {
                onoff = !onoff;
                Debug.Log("1");
            }
            else {
                onoff = !onoff;
                Debug.Log("2"); }
        }
        
            
        //if (onoff)
        //{
        //    if (toggle.isOn)
        //    {
        //        playaudio();
        //    }
        //    else
        //    {
        //        pauseudio();
        //    }
        //}
    }

}
