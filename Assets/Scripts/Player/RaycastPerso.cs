﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastPerso : MonoBehaviour
{
    // Grillage

    public static bool getDoorGrillage = false;
    // Labo 

    // DoorLabo
    public static bool getDoorLabo = false;
    // Keylabo
    public static bool keyLabo = false;
    // LecteurLabo
    public static bool lecteurLabo = false;
    public GameObject lecteurRouge;
    public GameObject lecteurRougeValide;
    // public static bool keyLabo = false;
    // Game Object
    // public GameObject objectLaboKey;

    public static bool getDoorSDM = false;

    // Sortie

    public static bool getDoorSortie = false;
    public static bool keySortie = false;
    public static bool lecteurS = false;
    public GameObject lecteurCS;
    public GameObject lecteurSValide;

    // Quartiers

    public static bool getDoorQuartiers = false;

    // Chambre Gucci

    public static bool getDoorGC = false;
    // KeyA
    public static bool keyGucci = false;
    // LecteurA
    public static bool lecteurG = false;
    public GameObject lecteurCG;
    public GameObject lecteurGValide;

    // Chambre A

    public static bool getDoorA = false;
    // KeyA
    public static bool keyA = false;
    // LecteurA
    public static bool lecteurA = false;
    public GameObject lecteurCA;
    public GameObject lecteurAValide;

    // Chambre B

    public static bool getDoorB = false;

    // Chambre C

    public static bool getDoorC = false;

    // KeyA
    public static bool keyC = false;
    // LecteurA
    public static bool lecteurC = false;
    public GameObject lecteurCC;
    public GameObject lecteurCValide;


    // Salle de Pause

    public static bool getDoorPause = false;
    // KeyA
    public static bool keyPause = false;
    // LecteurA
    public static bool lecteurP = false;
    public GameObject lecteurCP;
    public GameObject lecteurPValide;

    public static bool getDoorCouloir = false;

    public static bool getMedic1 = false;

    public static bool getMedic2 = false;

    public static bool getMedic3 = false;

    public static bool getMedic4 = false;

    public static bool getMedic5 = false;

    // Composant Machines
    public static bool composant = false;
    public GameObject composantMachine;
    public static bool cdm = false;

    //Extincteur

    public static bool extincteur = false;
    public GameObject pchit;
    public GameObject flash;

    /* [Header("Lunettes Go")]
    public GameObject lunettes1;
    public GameObject lunettes2;
    public GameObject lunettes3;
    public GameObject lunettes4;
    public GameObject lunettes5;
    public GameObject lunettes6;
    public GameObject lunettesmap;
    public GameObject lunettesfollowme;
    public GameObject lunettespass;

    public AudioSource keySound;
    public AudioSource medicboxsound;
    public AudioSource dooropening;
    public AudioSource badger;
    public AudioSource vento;
    public AudioSource composantas;
    public AudioSource machineas;
    public AudioSource extincteuras;
    public AudioSource lunettesas;
    public AudioSource lockeddoor;
    */

    //Medic Bool

    private bool medicbool1 = false;
    private bool medicbool2 = false;
    private bool medicbool3 = false;
    private bool medicbool4 = false;
    private bool medicbool5 = false;
    private bool machinecheck = false;



    void Start()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.

        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.

        layerMask = ~layerMask;

        RaycastHit hit;

        // Does the ray intersect any objects excluding the player layer
        Debug.DrawRay(transform.position, transform.forward * 5, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 4, layerMask)) //Range de 4
        {
            //Debug.Log(hit.transform.name);

            // Input sur le E

            if (Input.GetKeyDown(KeyCode.E)) 
            {

                // LABO

                if (hit.collider.gameObject.CompareTag("Door Labo") && lecteurLabo == true) 
                {
                    getDoorLabo = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");

                    FindObjectOfType<AudioManager>().Play("Door");
                }
                if(hit.collider.gameObject.CompareTag("Door Labo") && lecteurLabo == false)
                {
                    FindObjectOfType<AudioManager>().Play("Door Locked");
                }
                if (hit.collider.gameObject.CompareTag("KeyLabo"))
                {
                    keyLabo = true;
                    FindObjectOfType<AudioManager>().Play("Take");
                    Destroy(hit.transform.gameObject);
                }
                if (hit.collider.gameObject.CompareTag("LecteurLabo") && keyLabo == true)
                {
                    lecteurRouge.SetActive(false);
                    lecteurRougeValide.SetActive(true);
                    lecteurLabo = true;

                    FindObjectOfType<AudioManager>().Play("Badger");
                }

                    // Sortie

                    if (hit.collider.gameObject.CompareTag("Door Sortie") && lecteurS == true)
                {
                    getDoorSortie = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }
                    if(hit.collider.gameObject.CompareTag("Door Sortie") && lecteurS == false)
                {
                    FindObjectOfType<AudioManager>().Play("Door Locked");
                }
                if (hit.collider.gameObject.CompareTag("KeySortie"))
                {
                    keySortie = true;
                    FindObjectOfType<AudioManager>().Play("Take");
                    Destroy(hit.transform.gameObject);
                }
                if (hit.collider.gameObject.CompareTag("LSortie") && keySortie == true)
                {
                    lecteurCS.SetActive(false);
                    lecteurSValide.SetActive(true);
                    lecteurS = true;

                    FindObjectOfType<AudioManager>().Play("Badger");
                }

                // SDM

                if (hit.collider.gameObject.CompareTag("Door SDM"))
                {
                    getDoorSDM = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }

                // Quartiers

                if (hit.collider.gameObject.CompareTag("Door Quartiers"))
                {
                    getDoorQuartiers = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }

                // Grande Chambre

                if (hit.collider.gameObject.CompareTag("Door GC") && lecteurG == true)
                {
                    getDoorGC = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }
                if(hit.collider.gameObject.CompareTag("Door GC") && lecteurG == false)
                {
                    FindObjectOfType<AudioManager>().Play("Door Locked");
                }
                if (hit.collider.gameObject.CompareTag("KeyGucci"))
                {
                    keyGucci = true;
                    FindObjectOfType<AudioManager>().Play("Take");
                    Destroy(hit.transform.gameObject);
                }
                if (hit.collider.gameObject.CompareTag("LGucci") && keyGucci == true)
                {
                    lecteurCG.SetActive(false);
                    lecteurGValide.SetActive(true);
                    lecteurG = true;

                    FindObjectOfType<AudioManager>().Play("Badger");
                }

                // Chambre A

                if (hit.collider.gameObject.CompareTag("Door A") && lecteurA == true)
                {
                    getDoorA = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }
                if(hit.collider.gameObject.CompareTag("Door A") && lecteurA == false)
                {
                    FindObjectOfType<AudioManager>().Play("Door Locked");
                }
                if (hit.collider.gameObject.CompareTag("KeyA"))
                {
                    keyA = true;
                    FindObjectOfType<AudioManager>().Play("Take");
                    Destroy(hit.transform.gameObject);
                }
                if (hit.collider.gameObject.CompareTag("LecteurCarteA") && keyA == true)
                {
                    lecteurCA.SetActive(false);
                    lecteurAValide.SetActive(true);
                    lecteurA = true;

                    FindObjectOfType<AudioManager>().Play("Badger");
                }

                // Chambre B

                if (hit.collider.gameObject.CompareTag("Door B"))
                {
                    getDoorB = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }

                // Chambre C

                if (hit.collider.gameObject.CompareTag("Door C") && lecteurC == true)
                {
                    getDoorC = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }
                if(hit.collider.gameObject.CompareTag("Door C") && lecteurC == false)
                {
                    FindObjectOfType<AudioManager>().Play("Door Locked");
                }
                if (hit.collider.gameObject.CompareTag("KeyC"))
                {
                    keyC = true;
                    FindObjectOfType<AudioManager>().Play("Take");
                    Destroy(hit.transform.gameObject);
                }
                if (hit.collider.gameObject.CompareTag("LecteurC") && keyC == true)
                {
                    lecteurCC.SetActive(false);
                    lecteurCValide.SetActive(true);
                    lecteurC = true;

                    FindObjectOfType<AudioManager>().Play("Badger");
                }

                // Salle Pause

                if (hit.collider.gameObject.CompareTag("Door Pause") && lecteurP == true)
                {
                    getDoorPause = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }
                if (hit.collider.gameObject.CompareTag("Door Pause") && lecteurP == false)
                {
                    FindObjectOfType<AudioManager>().Play("Door Locked");
                }
                if (hit.collider.gameObject.CompareTag("KeyPause"))
                {
                    keyPause = true;
                    FindObjectOfType<AudioManager>().Play("Take");
                    Destroy(hit.transform.gameObject);
                }
                if (hit.collider.gameObject.CompareTag("LecteurPause") && keyPause == true)
                {
                    lecteurCP.SetActive(false);
                    lecteurPValide.SetActive(true);
                    lecteurP = true;

                    FindObjectOfType<AudioManager>().Play("Badger");
                }

                // Couloir

                if (hit.collider.gameObject.CompareTag("Door Couloir"))
                {
                    getDoorCouloir = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                    FindObjectOfType<AudioManager>().Play("Door");
                }

                // Grillage

                if (hit.collider.gameObject.CompareTag("DoorGrillage"))
                {
                    getDoorGrillage = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Medics 

                // Medic 1

                if (hit.collider.gameObject.CompareTag("Boite Medic 1") && medicbool1 == false)
                {
                    getMedic1 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                    FindObjectOfType<AudioManager>().Play("Door Medic");
                    medicbool1 = true;
                }

                if (hit.collider.gameObject.CompareTag("Boite Medic 2") && medicbool2 == false)
                {
                    getMedic2 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                    FindObjectOfType<AudioManager>().Play("Door Medic");
                    medicbool2 = true;
                }

                if (hit.collider.gameObject.CompareTag("Boite Medic 3") && medicbool3 == false)
                {
                    getMedic3 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                    FindObjectOfType<AudioManager>().Play("Door Medic");
                    medicbool3 = true;
                }

                if (hit.collider.gameObject.CompareTag("Boite Medic 4") && medicbool4 == false)
                {
                    getMedic4 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                    FindObjectOfType<AudioManager>().Play("Door Medic");
                    medicbool4 = true;
                }

                if (hit.collider.gameObject.CompareTag("Boite Medic 5") && medicbool5 == false)
                {
                    getMedic5 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                    FindObjectOfType<AudioManager>().Play("Door Medic");
                    medicbool5 = true;
                }

                // Ventoline

                if (hit.collider.gameObject.CompareTag("Ventoline"))
                {
                    PlayerActions.ventoline++;
                    Debug.Log("J'ai  trouvé de la Ventoline");
                    Destroy(hit.transform.gameObject);
                    FindObjectOfType<AudioManager>().Play("Take");
                }

                // Composant Electrique et machine

                if (hit.collider.gameObject.CompareTag("Composant"))
                {
                    composant = true;
                    Destroy(hit.transform.gameObject);
                    FindObjectOfType<AudioManager>().Play("Take");
                }
                if (hit.collider.gameObject.CompareTag("Machine") && composant == true && machinecheck == false) 
                {
                    cdm = true;
                    composantMachine.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Machine");
                    machinecheck = true;
                }

                // Extincteur

                if (hit.collider.gameObject.CompareTag("Extincteur"))
                {
                    extincteur = true;
                    Destroy(hit.transform.gameObject);
                    flash.SetActive(false);
                    pchit.SetActive(true);
                    FindObjectOfType<AudioManager>().Play("Take");
                }

                // Lunettes

                if (hit.collider.gameObject.CompareTag("Lunettes"))
                {
                    Destroy(hit.transform.gameObject);
                    /* lunettes1.SetActive(true);
                     lunettes2.SetActive(true);
                     lunettes3.SetActive(true);
                     lunettes4.SetActive(true);
                     lunettes5.SetActive(true);
                     lunettes6.SetActive(true);
                     lunettesmap.SetActive(true);
                     lunettesfollowme.SetActive(true);
                     lunettespass.SetActive(true); */
                    FindObjectOfType<AudioManager>().Play("Take");
                }


            }





            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                //Debug.Log("Did not Hit");
            }
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5, layerMask))
            {

            }
        }

    }
}
