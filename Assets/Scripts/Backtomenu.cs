using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtomenu : MonoBehaviour
{
    private float counterbacktomenu = 0f;

    private GameObject chrono;

    public GameObject scoredisplay;
    public GameObject video;
    void Start()
    {
        chrono = GameObject.FindGameObjectWithTag("Chrono");
    }

    // Update is called once per frame
    void Update()
    {

        counterbacktomenu = counterbacktomenu + Time.deltaTime;

        if (counterbacktomenu >= 41f)
        {
            scoredisplay.SetActive(true);

        }
        if (counterbacktomenu >= 46f)
        {
            SceneManager.LoadScene(0);
            Destroy(chrono);
            
        }
    }
}
