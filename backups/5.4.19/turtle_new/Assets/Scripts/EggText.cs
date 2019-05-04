using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggText : MonoBehaviour
{
    private Text text;
        
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "You have survived a full life cycle. How will you spend your leftover lifespan? You have " + StaticStats.getLife() + " life to spend.";
    }
}
