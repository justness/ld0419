using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeGrass : MonoBehaviour     //THIS HAS PROBLEMATIC BEHAVIOURS
{
    public GameObject crick;
    public GameObject grass;

    void Start()
    {
        crick = GameObject.Find("CricketPatch");
        grass = GameObject.Find("Grass");
        Vector3 crickLoc = crick.transform.position;
        int rand = Random.Range(2, 4);
        int i = 0;
        while (i <= rand)
        {
            Instantiate(grass, crickLoc + (Random.insideUnitSphere * 0.1f), Quaternion.identity);
            
            i++;
        }
        Debug.Log(rand);
    }

    void Update()
    {

    }
}
