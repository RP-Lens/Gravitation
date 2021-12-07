using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLapse : MonoBehaviour
{    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            Time.timeScale = 1;
        }
        if (Input.GetKey("2"))
        {
            Time.timeScale = 2;
        }
        if (Input.GetKey("5"))
        {
            Time.timeScale = 5;
        }
        if (Input.GetKey("0"))
        {
            Time.timeScale = 10;
        }
        if (Input.GetKey("u"))
        {
            Time.timeScale = 50;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
        }
    }
}
