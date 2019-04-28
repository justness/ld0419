using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfModel : MonoBehaviour
{

    public GameObject player; //follow player
    //private Vector3 offset; //follow player

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.W))
        {
            //goUpAndDown(); //this was for PlayerWaterController.cs
            //move.y = 1000; //this didn't work
            Quaternion target = Quaternion.Euler(20, 180, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);

        }
    
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.S))
        {
            //goUpAndDown();
            //move.y = 1000; //this didn't work
            Quaternion target = Quaternion.Euler(-20, 180, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
        }

        else
        {*/
            //Quaternion target = Quaternion.Euler(0, 180, 0);
            Quaternion target = player.transform.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
        //}
    }
}
