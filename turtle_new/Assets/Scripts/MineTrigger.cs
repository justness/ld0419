using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MineTrigger : MonoBehaviour
{

    public GameObject mine;
    public GameObject poison;
    public AudioSource aud;
    public RawImage img;

    void Start()
    {
        mine = GameObject.Find("Mine");
        poison = mine.gameObject.transform.GetChild(0).gameObject;
        aud = mine.GetComponent<AudioSource>();
        img.enabled = false;
    }

    void Update()
    {
        if (StaticStats.getPois() == true)      //Check for poison status per tick and updates health.
        {
            StaticStats.setLife(StaticStats.getLife() - 0.1);
        }

        if (StaticStats.getLife() <= 0)
        {
            SceneManager.LoadScene("Death");
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == poison)
        {
            img.enabled = true;
            Debug.Log("Collision");
            StaticStats.setPois(true);      //Sets poison to true when colliding.
        }
        if (col.gameObject == mine)
        {
            StaticStats.setLife(StaticStats.getLife() - 10);        //Boom.
            aud.Play();
        }
    }

    private void OnTriggerExit (Collider col)
    {
        if (col.gameObject == poison)       //Disables poison when too far.
        {
            StaticStats.setPois(false);
            img.enabled = false;
        }
    }
}
