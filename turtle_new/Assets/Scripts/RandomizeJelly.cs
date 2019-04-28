using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeJelly : MonoBehaviour
{

    public GameObject jelly;
    public int min;
    public int max;

    void Start()
    {
        jelly = GameObject.Find("Jellyfish");
        int rand = Random.Range(min, max);
        int i = 0;
        while (i <= rand)
        {
            Instantiate(jelly, Random.insideUnitSphere * 50, Quaternion.identity);
            i++;
        }
        Debug.Log(rand);
    }

    void Update()
    {

    }

}
