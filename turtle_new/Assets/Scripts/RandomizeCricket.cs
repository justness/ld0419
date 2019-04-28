using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeCricket : MonoBehaviour
{

    public GameObject crick;
    public int min;
    public int max;

    void Start()
    {
        crick = GameObject.Find("CricketPatch");
        int rand = Random.Range(min, max);
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
