using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastPerso : MonoBehaviour
{
    // Labo 

    // DoorLabo
    public static bool getDoorLabo = false;
    // Keylabo
    // public static bool keyLabo = false;
    // Game Object
    // public GameObject objectLaboKey;

    public static bool getDoorSDM = false;

    public static bool getDoorSortie = false;

    public static bool getDoorQuartiers = false;

    public static bool getDoorGC = false;

    public static bool getDoorA = false;

    public static bool getDoorB = false;

    public static bool getDoorC = false;

    public static bool getDoorPause = false;

    public static bool getDoorCouloir = false;

    public static bool getMedic1 = false;

    public static bool getMedic2 = false;

    public static bool getMedic3 = false;

    public static bool getMedic4 = false;

    public static bool getMedic5 = false;

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

        if (Physics.Raycast(transform.position, transform.forward, out hit, 3, layerMask)) //Range de 3
        {
            Debug.Log(hit.transform.name);

            // Input sur le E

            if (Input.GetKeyDown(KeyCode.E)) 
            {

                // LABO

                if (hit.collider.gameObject.CompareTag("Door Labo")) 
                {
                    getDoorLabo = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }
                if (hit.collider.gameObject.CompareTag("KeyLabo"))
                {
                    // objectLaboKey.SetActive(true);
                    // keyLabo = true;
                }

                // Sortie

                if (hit.collider.gameObject.CompareTag("Door Sortie"))
                {
                    getDoorSortie = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // SDM

                if (hit.collider.gameObject.CompareTag("Door SDM"))
                {
                    getDoorSDM = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Quartiers

                if (hit.collider.gameObject.CompareTag("Door Quartiers"))
                {
                    getDoorQuartiers = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Grande Chambre

                if (hit.collider.gameObject.CompareTag("Door GC"))
                {
                    getDoorGC = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Chambre A

                if (hit.collider.gameObject.CompareTag("Door A"))
                {
                    getDoorA = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Chambre B

                if (hit.collider.gameObject.CompareTag("Door B"))
                {
                    getDoorB = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Chambre C

                if (hit.collider.gameObject.CompareTag("Door C"))
                {
                    getDoorC = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Salle Pause

                if (hit.collider.gameObject.CompareTag("Door Pause"))
                {
                    getDoorPause = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Couloir

                if (hit.collider.gameObject.CompareTag("Door Couloir"))
                {
                    getDoorCouloir = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }

                // Medics 

                // Medic 1

                if (hit.collider.gameObject.CompareTag("Boite Medic 1"))
                {
                    getMedic1 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                }

                if (hit.collider.gameObject.CompareTag("Boite Medic 2"))
                {
                    getMedic2 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                }

                if (hit.collider.gameObject.CompareTag("Boite Medic 3"))
                {
                    getMedic3 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                }

                if (hit.collider.gameObject.CompareTag("Boite Medic 4"))
                {
                    getMedic4 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                }

                if (hit.collider.gameObject.CompareTag("Boite Medic 5"))
                {
                    getMedic5 = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Medic !");
                }

                // Ventoline

                if (hit.collider.gameObject.CompareTag("Ventoline"))
                {
                    PlayerActions.ventoline++;
                    Debug.Log("J'ai  trouvé de la Ventoline");
                    Destroy(hit.transform.gameObject);
                }


            }





            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                Debug.Log("Did not Hit");
            }
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5, layerMask))
            {

            }
        }

    }
}
