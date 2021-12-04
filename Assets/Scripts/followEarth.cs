using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followEarth : MonoBehaviour
{
    private int which = 0;

    GameObject earth;

    GameObject[] objects = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        //Initialise shiz
        earth = GameObject.Find("Earth");
        objects[0] = GameObject.Find("Moon");
        objects[1] = GameObject.Find("Asteroid");
        objects[2] = earth;

        transform.position = earth.transform.position + (Vector3.back * 10) + (Vector3.up * 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = earth.transform.position + (Vector3.back * 50) + (Vector3.up * 50);
        if (Input.GetKey("p"))
        {
            which = 0;
        }else if (Input.GetKey("["))
        {
            which = 1;
        }else if (Input.GetKey("]"))
        {
            which = 2;
        }
        
        transform.LookAt(objects[which].transform.position);
    }
}
