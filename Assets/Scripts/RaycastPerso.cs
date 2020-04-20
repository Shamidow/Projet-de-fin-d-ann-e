using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastPerso : MonoBehaviour
{
    // Labo 

    // DoorLabo
    public static bool getDoorLabo = false; 
    // Keylabo
    public static bool keyLabo = false;
    // Game Object
    public GameObject objectLaboKey;

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

            
            if (Input.GetKeyDown(KeyCode.E)) // Input sur le E
            {
                if (hit.collider.gameObject.CompareTag("Door Labo")) // Un comparetag sur le raycast
                {
                    getDoorLabo = true; // getFlash est un static qui va tirgger le script de la flashlight
                    Debug.Log("Door Opening");
                }
                if (hit.collider.gameObject.CompareTag("KeyLabo"))
                {
                    objectLaboKey.SetActive(true);
                    keyLabo = true;
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
