using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JellyBagTrigger : MonoBehaviour
{

    public GameObject jelly;
    public GameObject bag;

    void Start()
    {
        jelly = GameObject.Find("Jellyfish");
        bag = GameObject.Find("PlasticBag");
    }

    void Update()
    {
        /*if (hunger >= 0)
        {
            health -= 5 * Time.deltaTime;   //Lose health per tick while starving.
        }*/
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == jelly)
        {
            //hunger += 10;
        }
        if (col.gameObject == bag)
        {
            //hunger -= 10;
        }
    }
}
