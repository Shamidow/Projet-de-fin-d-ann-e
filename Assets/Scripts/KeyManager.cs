using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public GameObject voiceline;
    public static bool endlock = false;
    public GameObject key; // Permet de désactiver la clée correspondante


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {/* Créer une variable dans le Raycast perso en public static, et la mettre dans la condition du If, activer un bool static public déclaré ici qui agira sur la porte voulue.
        if (RaycastPerso.VARIABLEPUBLICSTATIC == true)
        {
            key.SetActive(true);
            endlock = true;
            Debug.Log("Fin Débloquée");
        }*/
    }
}
