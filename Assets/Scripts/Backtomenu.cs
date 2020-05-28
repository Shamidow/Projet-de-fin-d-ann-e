using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtomenu : MonoBehaviour
{
    private float counterbacktomenu = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counterbacktomenu = counterbacktomenu + Time.deltaTime;

        if(counterbacktomenu >= 41f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
