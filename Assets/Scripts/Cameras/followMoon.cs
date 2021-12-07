using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMoon : MonoBehaviour
{
    GameObject moon;
    GameObject earth;

    // Start is called before the first frame update
    void Start()
    {
        //Initialise shiz
        moon = GameObject.Find("Moon");
        earth = GameObject.Find("Earth");

        transform.position = moon.transform.position + (Vector3.back * 10) + (Vector3.up * 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = moon.transform.position + (Vector3.back * 50) + (Vector3.up * 50);
        transform.LookAt(earth.transform.position);
    }
}
