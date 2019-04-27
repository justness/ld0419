using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OceanTrigger : MonoBehaviour
{

    public GameObject ocean;
    public GameObject death;

    void Start()
    {
        ocean = GameObject.Find("OceanCollider");
        death = GameObject.Find("DeathCollider");
    }

    void Update()
    {
        /*if (Input.GetKeyDown("x"))
        {
            SceneManager.LoadScene("Juvenile");
            //SceneManager.UnloadSceneAsync("Birth");
        }*/ //THIS WORKS FOR TESTING PURPOSES
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject == ocean)
        {
            SceneManager.LoadScene("Juvenile");
        }

        if (col.gameObject == death)
        {
            SceneManager.LoadScene("Death");
        }
    }
}
