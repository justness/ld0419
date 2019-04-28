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
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation * rotOffset;

        /*// Camera Movement //an example script to play with, I didn't make this one
        Vector3 movement = CameraGoalPosition - transform.position;
        movement = movement / MovementDividor;
        transform.position += movement;

        // Camera Look At
        vector3 movementA = CameraGoalLookAt - CameraCurrentLookAt;
        movementA = movementA / LookAtDividor;
        CameraCurrentLookAt += movementA;
        transform.lookat(CameraCurrentLookAt);*/

        //transform.position = player.transform.position + offset; //follow player
        //transform.rotation = player.transform.rotation * rotOffset; //having issues with right stick
        //transform.rotation = player.transform.rotation;
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