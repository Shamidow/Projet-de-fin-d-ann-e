using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checklist : MonoBehaviour
{
    private bool inventoryshowed = false;
    public GameObject inventory;

    // GO Check
    public GameObject ltp;
    public GameObject keycardrouge;
    public GameObject keycardblanc;
    public GameObject keycardvert;
    public GameObject keycardjaune;
    public GameObject keycardbleu;
    public GameObject keycardviolet;
    public GameObject composant;
    public GameObject lunettes;
    public GameObject extincteur;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventoryshowed)
            {
                InventoryHide();
                inventoryshowed = false;
            }
            else
            {
                Inventory();
                inventoryshowed = true;
            }
        }
        if(RaycastPerso.ltb == true)
        {
            ltp.SetActive(true);
        }
        if(RaycastPerso.keycardrouge == true)
        {
            keycardrouge.SetActive(true);
        }
        if(RaycastPerso.keycardblanc == true)
        {
            keycardblanc.SetActive(true);
        }
        if(RaycastPerso.keycardvert == true)
        {
            keycardvert.SetActive(true);
        }
        if(RaycastPerso.keycardjaune == true)
        {
            keycardjaune.SetActive(true);
        }
        if(RaycastPerso.keycardbleu == true)
        {
            keycardbleu.SetActive(true);
        }
        if (RaycastPerso.keycardviolet == true)
        {
            keycardviolet.SetActive(true);
        }
        if(RaycastPerso.composantb == true)
        {
            composant.SetActive(true);
        }
        if(RaycastPerso.protolunettes == true)
        {
            lunettes.SetActive(true);
        }
        if(RaycastPerso.extincteurb == true)
        {
            extincteur.SetActive(true);
        }
    }
    void InventoryHide()
    {
        inventory.SetActive(false);
    }
    void Inventory()
    {
        inventory.SetActive(true);
    }
}
