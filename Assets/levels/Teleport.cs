using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    bool display = false;
    public GameObject objToTP;
    public Transform tpLoc;
    void Start()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objToTP.GetComponent<CharacterController>().enabled = false;
            objToTP.transform.position = tpLoc.transform.position;
            objToTP.GetComponent<CharacterController>().enabled = true;
        }

    }
}