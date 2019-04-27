using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWaterController : MonoBehaviour
{
    public CharacterController _controller;
    public float _speed = 10;
    public float _rotationSpeed = 180;
    public float upAndDownSpeed = 7;
    Vector3 moveUp;
    public Rigidbody turtleRigidbody;

    private Vector3 rotation;

    public void RemoveHealth()
    {
        StaticStats.setLife(StaticStats.getLife() - 0.5);
    }
    
    public void goUpAndDown() //this is tied to w and s keys due to the "_controller.Move"
    {
        //Vector3 goUpAndDown = new Vector3(0, 2f, 0);
        //turtleRigidbody.AddForce(Vector3.up * 56999f);
        Debug.Log("goUpAndDown");
        Vector3 goUp = new Vector3(0, Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        goUp = this.transform.TransformDirection(goUp);
        _controller.Move(goUp * upAndDownSpeed);
    }

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            RemoveHealth();
        }
    }

    public void Start()
    {
        turtleRigidbody = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        _controller.Move(move * _speed);
        this.transform.Rotate(this.rotation);

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.W))
        {
            goUpAndDown();
            //move.y = 1000; //this didn't work
            //Quaternion target = Quaternion.Euler(-45, 0, 0);
            //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
            Vector3 stayInPlaceW = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
            stayInPlaceW = this.transform.TransformDirection(stayInPlaceW);
            _controller.Move(stayInPlaceW * _speed * -1);

        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.S))
        {
            goUpAndDown();
            //move.y = 1000; //this didn't work
            //Quaternion target = Quaternion.Euler(45, 0, 0);
            //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
            Vector3 stayInPlaceW = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
            stayInPlaceW = this.transform.TransformDirection(stayInPlaceW);
            _controller.Move(stayInPlaceW * _speed * -1);

        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed = 30;
            //this should also remove health
        }
        else
        {
            _speed = 10;
        }
    }
}
