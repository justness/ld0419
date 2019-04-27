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
}
