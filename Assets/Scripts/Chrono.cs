using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chrono : MonoBehaviour
{
    public static float timer;
    public static bool timeron = true;
    void Start()
    {
        Object.DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if(timeron == true)
        {
            timer = timer + Time.deltaTime;
        }
        if(timeron == false)
        {
            return;
        }
    }
    
}
