using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifebarVisual : MonoBehaviour
{

    public RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    void Update()
    {
        rt.sizeDelta = new Vector2(5, 250 * ((float)StaticStats.getLife() / 1000));
        //StaticStats.setLife(StaticStats.getLife() - 20);                 //WE NEED TO HAVE A CONSISTENT SCRIPT REDUCING/MANAGING STATS

        if ((StaticStats.getLife() / 1000) <= 0.2)
        {
           //  = new Color32(255, 0, 0, 255);       //SHOULD CHANGE BAR TO RED WHEN IN DANGER ZONE
        }
    }
}
