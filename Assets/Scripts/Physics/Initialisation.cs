using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialisation : MonoBehaviour
{
    public Vector3 moonSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
        //Define gameobject
        GameObject earth = GameObject.Find("Earth");

        //Create satellites
        GameObject moon = GameObject.Find("Moon");
        GameObject moonTrail = GameObject.Find("/Moon/moonTrail");
        moonTrail.GetComponent<TrailRenderer>().emitting = false;

        //Define Rigidbodies
        Rigidbody rbM = moon.GetComponent<Rigidbody>();
        Rigidbody rbE = earth.GetComponent<Rigidbody>();

        //Set the parameters of the moon
        rbM.mass = (float) (1.2 / 100) * rbE.mass;
        moon.transform.position = Vector3.left * (float) (56.5f * 3);

        //Apply initial velocities to objects
        rbM.velocity += moonSpeed;
        rbE.velocity += Vector3.up + Vector3.forward;

        moonTrail.GetComponent<TrailRenderer>().emitting = true;

        readStuff.planet[] planets = GameObject.Find("ObjectManager").GetComponent<readStuff>().readInfo();
    }
}