using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController _controller;
    public float _speed = 10;
    public float _rotationSpeed = 180;

    private Vector3 rotation;

    public void Update()
    {
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        _controller.Move(move * _speed);
        this.transform.Rotate(this.rotation);
    }

    /*CharacterController control;

    public float speed = 6.0f;
    public float gravity = 20.0f;
    public float rotSpeed = 90;

    private Vector3 moveDirection = Vector3.zero;
    
    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0.0f, Input.GetAxis("Vertical") * Time.deltaTime);
        moveDirection *= speed;
        moveDirection.y -= gravity * Time.deltaTime;

        if (Input.GetAxis("Horizontal") > 0)
        {
            
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            
        }

        control.Move(moveDirection * Time.deltaTime);
    }*/
}
