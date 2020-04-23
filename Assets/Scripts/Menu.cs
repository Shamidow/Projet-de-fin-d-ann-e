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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Jouer() // Permets de load une scène
    {
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
        menuMenu.SetActive(true);
    }

    public void Options()
    {
        optionsMenu.SetActive(true);
        menuMenu.SetActive(false);
    }
}
