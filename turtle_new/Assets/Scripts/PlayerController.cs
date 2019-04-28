//this entire script is probably obsolete, rewriting it using rigidbody instead of playercontroller for gravity reasons

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController _controller;
    public float _speed = 10;
    public float _rotationSpeed = 180;
    public float gravity = 9000;

    private Vector3 rotation;

    /*void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }*/
    //This playercontroller is for the initial land-section. Can update parts to reuse for final scene. Other scenes better with new player object.

    public void Update()
    {
        /*Vector3 gravityVector = new Vector3(0, gravity, 0);
        _controller.enabled = false;
        transform.Translate(gravityVector * Time.deltaTime * -1);
        //_controller.transform.position = new Vector3(some location);
        _controller.enabled = true;
        //transform.Translate(gravityVector * Time.deltaTime * -1);

        /*if (transform.position.y > 0)
        {
            transform.Translate(gravityVector * Time.deltaTime * -1);
        }*/ //"artificial" gravity ideas above, pick and choose

        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);    //Update for underwater (actual vertical movement).
        move = this.transform.TransformDirection(move);
        _controller.Move(move * _speed);
        this.transform.Rotate(this.rotation);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed = 30;
            //Action item: this should also remove health
        }
        else
        {
            _speed = 10;
        }   
    }
}