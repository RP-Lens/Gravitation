using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public Camera[] cameras = new Camera[3];

    private int count = 0;

    private void Start()
    {
        //Enable camera 0
        cameras[0].enabled = true;

        //Disable all others
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].enabled = false;
        }
        count++;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //Loop through all cameras and set next one to true
            for (int i = 0; i < cameras.Length; i++)
            {
                if (i != count)
                {
                    cameras[i].enabled = false;
                }
                else
                {
                    cameras[i].enabled = true;
                }
            }
            
            //Set count to next index of cameras
            count++;
            if (count == cameras.Length)
            {
                count = 0;
            }
        }
    }
}
