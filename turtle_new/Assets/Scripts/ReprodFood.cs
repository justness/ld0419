using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReprodFood : MonoBehaviour
{
    public GameObject jelly;
    public int fed;
    public GameObject bc;

    void Start()
    {
        fed = 0;
        bc.active = false;
    }

    void Update()
    {
        if (fed >= 1)
        {
            bc.active = true;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == jelly)
        {
            fed = fed + 1;
        }
    }
}
