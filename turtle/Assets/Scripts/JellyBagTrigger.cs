

//deals with passive hunger and drain, and colisions with jellyfish (+hunger) and plastic bags (-health)
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

   void FixedUpdate() //using FixedUpdate for non-movement related items
   {
        if (StaticStats.getHunger() <= 0)
        {
            StaticStats.setLife(StaticStats.getLife() - 2);
        }

        StaticStats.setHunger(StaticStats.getHunger() - 0.5); //passive hunger drain

        Debug.Log(StaticStats.getLife());

        StaticStats.setLife(StaticStats.getLife() - 0.125); //passive life drain
   }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == jelly)
        {
            StaticStats.setHunger(StaticStats.getHunger() + 10);
        }
        if (col.gameObject == bag)
        {
            StaticStats.setLife(StaticStats.getLife() - 10);
        }
    }
}
