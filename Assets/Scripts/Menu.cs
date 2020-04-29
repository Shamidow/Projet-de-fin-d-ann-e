using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject commandesmenu;
    public GameObject commandes;
    public GameObject optionsMenu;
    public GameObject menuMenu;
    public GameObject pausemenu;

    Scene currentScene = SceneManager.GetActiveScene();

    string scenename;
    void Start()
    {
        scenename = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        scenename = currentScene.name;
    }

    public void Jouer() // Permets de load une scène
    {
        menuMenu.SetActive(false);
        SceneManager.LoadScene(1);
    }

    public void Quitter() // Permets de quitter le jeu dans la build
    {
        Application.Quit();
    }
    public void Aide()
    {
        commandes.SetActive(true);
        commandesmenu.SetActive(false);
    }
    public void AideBye()
    {
        commandes.SetActive(false);
        commandesmenu.SetActive(true);
    }

    public void ReturnOptions()
    {
        optionsMenu.SetActive(false);
        pausemenu.SetActive(true);
        if (scenename == "Menu")
        {
            menuMenu.SetActive(true);
        }
    }

    public void Options()
    {
        optionsMenu.SetActive(true);
        pausemenu.SetActive(false);
        if (scenename == "Menu")
        {
            menuMenu.SetActive(false);
        }
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        menuMenu.SetActive(true);
    }
}
