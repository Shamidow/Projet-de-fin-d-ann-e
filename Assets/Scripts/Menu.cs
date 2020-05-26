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
    public GameObject loading;

    public Scene currentScene;

    string scenename;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        scenename = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        scenename = currentScene.name;
    }

    public void PlayGame()
    {
        loading.SetActive(true);
        SceneManager.LoadScene("SampleScene 15");
        Time.timeScale = 1f;
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

    public void ResetStatic()
    {
        PlayerHP.hp = 100;
        PlayerHP.xMin = 0;
        PlayerHP.xMax = 100;
        InshallahRaycast.getDoorLabo = false;
        InshallahRaycast.keyLabo = false;
        // LecteurLabo
        InshallahRaycast.lecteurLabo = false;
        InshallahRaycast.keycardrouge = false;
        KeyManager.endlock = false;
        CloudScript.firstclose = false;
        Crouch.ControllerStatus = false;
        ChatBox.SetMessage = "";
        ChatBox.ChatUpdated = false;
        RaycastPerso.Ventolines = 0;
        PlayerActions.ventoline = 0;
        FlashlightController.isactive = true;
        FlashlightController.tl = 100f;
        // Grillage

        RaycastPerso.getDoorGrillage = false;
        /*// Labo 

        // DoorLabo
        RaycastPerso.getDoorLabo = false;
        // Keylabo
        RaycastPerso.keyLabo = false;
        // LecteurLabo
        RaycastPerso.lecteurLabo = false;

        // RaycastPerso.keyLabo = false;
        // Game Object
        // public GameObject objectLaboKey;
        */


        RaycastPerso.getDoorSDM = false;

        // Sortie

        RaycastPerso.getDoorSortie = false;
        RaycastPerso.keySortie = false;
        RaycastPerso.lecteurS = false;

        // Quartiers

        RaycastPerso.getDoorQuartiers = false;

        // Chambre Gucci

        RaycastPerso.getDoorGC = false;
        // KeyA
        RaycastPerso.keyGucci = false;
        // LecteurA
        RaycastPerso.lecteurG = false;

        // Chambre A

        RaycastPerso.getDoorA = false;
        // KeyA
        RaycastPerso.keyA = false;
        // LecteurA
        RaycastPerso.lecteurA = false;


        // Chambre B

        RaycastPerso.getDoorB = false;

        // Chambre C

        RaycastPerso.getDoorC = false;

        // KeyA
        RaycastPerso.keyC = false;
        // LecteurA
        RaycastPerso.lecteurC = false;



        // Salle de Pause

        RaycastPerso.getDoorPause = false;
        // KeyA
        RaycastPerso.keyPause = false;
        // LecteurA
        RaycastPerso.lecteurP = false;


        RaycastPerso.getDoorCouloir = false;

        RaycastPerso.getMedic1 = false;

        RaycastPerso.getMedic2 = false;

        RaycastPerso.getMedic3 = false;

        RaycastPerso.getMedic4 = false;

        RaycastPerso.getMedic5 = false;

        RaycastPerso.getDoorPlacard = false;

        RaycastPerso.getDoorPlacard2 = false;

        RaycastPerso.getDoorAleft = false;

        RaycastPerso.getDoorAright = false;

        RaycastPerso.getDoorCright = false;

        RaycastPerso.getDoorCleft = false;

        RaycastPerso.getDoorLabo1right = false;

        RaycastPerso.getDoorreposright = false;

        RaycastPerso.getDoorreposleft = false;

        RaycastPerso.getDoorgucci1right = false;

        RaycastPerso.getDoorgucci1left = false;

        RaycastPerso.getDoorgucci2right = false;

        RaycastPerso.getDoorgucci2left = false;

        RaycastPerso.getDoorbureaub = false;

        RaycastPerso.getDoorbureaua = false;

        RaycastPerso.getDoorbureauc = false;



        // Composant Machines
        RaycastPerso.composant = false;
        RaycastPerso.cdm = false;

        //Extincteur

        RaycastPerso.extincteur = false;

        RaycastPerso.ltb = false;
        //RaycastPerso.keycardrouge = false;
        RaycastPerso.keycardblanc = false;
        RaycastPerso.keycardvert = false;
        RaycastPerso.keycardjaune = false;
        RaycastPerso.keycardbleu = false;
        RaycastPerso.keycardviolet = false;
        RaycastPerso.composantb = false;
        RaycastPerso.protolunettes = false;
        RaycastPerso.extincteurb = false;
    }
}
