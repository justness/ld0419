using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePlastic : MonoBehaviour
{

    public GameObject plastic;
    public int min;
    public int max;

    void Start()
    {
        plastic = GameObject.Find("Plastic");
        int rand = Random.Range(min, max);
        int i = 0;
        while (i <= rand)
        {
            Instantiate(plastic, Random.insideUnitSphere * 50, Quaternion.identity);
            i++;
        }
        Debug.Log(rand);
    }

    void Update()
    {

    }
}
