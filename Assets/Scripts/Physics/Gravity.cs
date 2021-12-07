using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravity;

    void OnTriggerStay(Collider other) 
    {
        Rigidbody otherRB = other.GetComponent<Rigidbody>();
        Vector3 difference = this.transform.position - other.transform.position;

        float dist = difference.magnitude;
        Vector3 gravityDirection = difference.normalized;
        Vector3 gravityVector = (gravityDirection * gravity) / (dist * dist);

        otherRB.AddForce(gravityVector, ForceMode.Acceleration);
    }
}