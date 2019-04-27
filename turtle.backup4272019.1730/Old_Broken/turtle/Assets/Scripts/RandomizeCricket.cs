using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeCricket : MonoBehaviour
{

    public GameObject crick;

    void Start()
    {
        crick = GameObject.Find("CricketPatch");
        int rand = Random.Range(20, 25);
        int i = 0;
        while (i <= rand)
        {
            Instantiate(crick, Random.insideUnitSphere * 50, Quaternion.identity);
            i++;
        }
        Debug.Log(rand);
    }

    void Update()
    {

    }
}
