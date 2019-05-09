
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeMines : MonoBehaviour
{

    public GameObject mine;
    public int min;
    public int max;

    void Start()
    {
        mine = GameObject.Find("Mine");
        int rand = Random.Range(min,max);
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
