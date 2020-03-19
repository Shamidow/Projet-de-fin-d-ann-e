using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public GameObject credits;
    public GameObject titre;
    public GameObject mp1;
    public GameObject mp2;
    public GameObject creditsbutton;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void EndMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void Credits()
    {
        titre.SetActive(false);
        mp1.SetActive(false);
        creditsbutton.SetActive(false);
        credits.SetActive(true);
        mp2.SetActive(true);
    }
}
