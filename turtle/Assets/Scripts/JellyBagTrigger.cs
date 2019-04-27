

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
        if (StaticStats.getHunger() <= 0)
        {
            StaticStats.setLife(StaticStats.getLife() - 2);
        }
        StaticStats.setHunger(StaticStats.getHunger() - 0.5);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == jelly)
        {
            StaticStats.setHunger(StaticStats.getHunger() + 10);
        }
        if (col.gameObject == bag)
        {
            StaticStats.setHunger(StaticStats.getHunger() - 10);
        }
    }
}
