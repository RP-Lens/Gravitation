using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followEarth : MonoBehaviour
{
    GameObject earth;
    GameObject moon;

    // Start is called before the first frame update
    void Start()
    {
        //Initialise shiz
        earth = GameObject.Find("Earth");
        moon= GameObject.Find("Moon");

        transform.position = earth.transform.position + (Vector3.back * 10) + (Vector3.up * 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = earth.transform.position + (Vector3.back * 50) + (Vector3.up * 50);        
        transform.LookAt(moon.transform.position);
    }
}
