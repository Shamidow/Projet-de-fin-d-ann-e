using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InshallahRaycast : MonoBehaviour
{
    public static bool getDoorLabo = false;

    public static bool keyLabo = false;
    // LecteurLabo
    public static bool lecteurLabo = false;
    public GameObject lecteurRouge;
    public GameObject lecteurRougeValide;
    public bool door1 = false;
    public static bool keycardrouge = false;

    bool vonce1 = false;

    void Start()
    {

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
                    getDoorLabo = true; // getDoorLabo est un static qui va tirgger le script de la door
                    Debug.Log("Door Opening");
                    if (door1 == false)
                    {
                        FindObjectOfType<AudioManager>().Play("Door");
                        door1 = true;
                        return;
                    }
                    if (door1 == true)
                    {
                        FindObjectOfType<AudioManager>().Play("Door Close");
                        door1 = false;
                        return;
                    }
                }
                /*if(hit.collider.gameObject.CompareTag("Door Labo") && lecteurLabo == false)
                {
                    FindObjectOfType<AudioManager>().Play("Door Locked");
                }*/
                if (hit.collider.gameObject.CompareTag("KeyLabo"))
                {
                    keyLabo = true;
                    FindObjectOfType<AudioManager>().Play("Take");
                    Destroy(hit.transform.gameObject);
                    ChatBox.SetMessage = "Red pass acquired";
                    ChatBox.ChatUpdated = true;
                    keycardrouge = true;
                }
                if (hit.collider.gameObject.CompareTag("LecteurLabo") && keyLabo == false && vonce1 == false)
                {
                    FindObjectOfType<AudioManager>().Play("Door Close");
                    vonce1 = true;
                }
                if (hit.collider.gameObject.CompareTag("LecteurLabo") && keyLabo == true)
                {
                    lecteurRouge.SetActive(false);
                    lecteurRougeValide.SetActive(true);
                    lecteurLabo = true;

                    FindObjectOfType<AudioManager>().Play("Badger");
                }
                else
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                    //Debug.Log("Did not Hit");
                }
            }
        }
    }
}

