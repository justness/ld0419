using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathRestart : MonoBehaviour
{
    public Button DeathButton;

    void Start()
    {
        DeathButton.onClick.AddListener(Task);
    }

    void Task()
    {
        Debug.Log("Clicked");

        StaticStats.setLife(1000);
        StaticStats.setAir(100);
        StaticStats.setHunger(99999);
        StaticStats.setRing(false);
        StaticStats.setPois(false);

        SceneManager.LoadScene("Birth");
    }
}
