using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MineTrigger : MonoBehaviour
{

    public GameObject mine;
    public GameObject poison;

    void Start()
    {
        mine = GameObject.Find("Mine");
        poison = GameObject.Find("Poison");
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == mine)
        {
            //this.health -= -10;                 //Health should be a global int preserved across scenes. Air and hunger should be reset per scene. Speed slow-down from plastic rings should be preserved aross scenes.
        }
        if (col.gameObject == poison)
        {
            //this.health -= -0.5 * Time.deltaTime;       //Check if this successfully deals DoT.
        }
    }
}
