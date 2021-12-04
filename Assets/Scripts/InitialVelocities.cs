using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialVelocities : MonoBehaviour
{
    public Vector3 moonSpeed;
    public Vector3 asteroidSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Apply initial velocities to objects
        GameObject.Find("Moon").GetComponent<Rigidbody>().velocity += moonSpeed;
        GameObject.Find("Asteroid").GetComponent<Rigidbody>().velocity += asteroidSpeed;
    }
}
