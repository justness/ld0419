using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeachTrigger : MonoBehaviour
{

    public GameObject bc;

    void Start()
    {
        bc = GameObject.Find("BeachCol");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == bc)
        {
            SceneManager.LoadScene("SuccessEgg");
        }

        if (StaticStats.getLife() < 50)
        {
            SceneManager.LoadScene("Death");
        }
    }
}
