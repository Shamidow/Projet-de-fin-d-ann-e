using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayChrono : MonoBehaviour
{
    public Text displayscore;
    public string scorestring;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scorestring = Chrono.timer.ToString("F0");
        displayscore.text = "Time to complete : " + scorestring + " seconds";
    }
}
