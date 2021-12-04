using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if(Input.GetKey("a"))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if(Input.GetKey("e"))
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        if(Input.GetKey("q"))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if(Input.GetKey("w"))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if(Input.GetKey("s"))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.eulerAngles += Vector3.left * rotSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.eulerAngles += Vector3.right * rotSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += Vector3.down * rotSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles += Vector3.up * rotSpeed * Time.deltaTime;
        }

    }
}
