using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
using UnityEngine.UI;
=======
>>>>>>> parent of 53e63ac... Merge branch 'master' of https://github.com/justness/ld0419

public class MineTrigger : MonoBehaviour
{

    public GameObject mine;
    public GameObject poison;
<<<<<<< HEAD
    public AudioSource aud;
    public RawImage img;
=======
    public AudioSource explode;
>>>>>>> parent of 53e63ac... Merge branch 'master' of https://github.com/justness/ld0419

    void Start()
    {
        mine = GameObject.Find("Mine");
<<<<<<< HEAD
        poison = mine.gameObject.transform.GetChild(0).gameObject;
        aud = mine.GetComponent<AudioSource>();
        img.enabled = false;
=======
        poison = GameObject.Find("Poison");
        explode = mine.GetComponent<AudioSource>();
>>>>>>> parent of 53e63ac... Merge branch 'master' of https://github.com/justness/ld0419
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
<<<<<<< HEAD
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
=======
        if (col.gameObject == mine)
        {
            StaticStats.setLife(StaticStats.getLife() - 10);        //Boom.
            explode.Play();
        }
        if (col.gameObject == poison)
        {
            StaticStats.setPois(true);      //Sets poison to true when colliding.
>>>>>>> parent of 53e63ac... Merge branch 'master' of https://github.com/justness/ld0419
        }
    }

    private void OnTriggerExit (Collider col)
    {
        if (col.gameObject == poison)       //Disables poison when too far.
        {
            StaticStats.setPois(false);
<<<<<<< HEAD
            img.enabled = false;
=======
>>>>>>> parent of 53e63ac... Merge branch 'master' of https://github.com/justness/ld0419
        }
    }
}
