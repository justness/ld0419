﻿using System.Collections;
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
        if (StaticStats.getPois() == true)      //Check for poison status per tick and updates health.
        {
            StaticStats.setLife(StaticStats.getLife() - 0.1);
            Debug.Log("Health = " + StaticStats.getLife());
        }

        if (StaticStats.getLife() <= 0)
        {
            SceneManager.LoadScene("Death");
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == mine)
        {
            StaticStats.setLife(StaticStats.getLife() - 10);        //Boom.
            Debug.Log("Health = " + StaticStats.getLife());
        }
        if (col.gameObject == poison)
        {
            StaticStats.setPois(true);      //Sets poison to true when colliding.
        }
    }

    private void OnTriggerExit (Collider col)
    {
        if (col.gameObject == poison)       //Disables poison when too far.
        {
            StaticStats.setPois(false);
        }
    }
}
