using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MateTrigger : MonoBehaviour
{

    public GameObject mate;

    void Start()
    {
        mate = GameObject.Find("Mate");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == mate)
        {
            SceneManager.LoadScene("Mate");
        }
    }
}
