using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; //follow player
    private Vector3 offset; //follow player
    private Quaternion rotOffset;

    void Start()
    {
        offset = transform.position - player.transform.position; //follow player
        rotOffset = transform.rotation;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset; //follow player
        transform.rotation = player.transform.rotation * rotOffset;
    }

    /*void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.W))
        {
            //goUpAndDown();
            //move.y = 1000; //this didn't work
            Quaternion target = Quaternion.Euler(-45, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.S))
        {
            //goUpAndDown();
            //move.y = 1000; //this didn't work
            Quaternion target = Quaternion.Euler(45, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);

        }
    }*/
}