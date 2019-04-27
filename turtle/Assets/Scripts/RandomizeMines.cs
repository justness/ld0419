using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeMines : MonoBehaviour
{

    public GameObject mine;

    void Start()
    {
        mine = GameObject.Find("Mine");
        int rand = Random.Range(20,30);
        int i = 0;
        while (i <= rand)
        {
            Instantiate(mine, Random.insideUnitSphere * 50, Quaternion.identity);
            i++;
        }
        Debug.Log(rand);
    }

    void Update()
    {
        
    }
}
