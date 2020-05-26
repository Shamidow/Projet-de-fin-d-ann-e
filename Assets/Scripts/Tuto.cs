using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuto : MonoBehaviour
{
    public static int TutoStep = 0;
    // Start is called before the first frame update
    void Start()
    {
        TutoStep = 0;
     //   transform.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(FlashlightTake.torche);
        if (TutoStep == 1 && FlashlightController.tl < 1)
        {
            transform.GetComponentInChildren<Text>().text = "Appuyer plusieurs fois sur A pour recharger la dynamo de la lampe torche";
                TutoStep = 2;
            Debug.Log("To recharge the flashlight battery press A");
        }
        if (TutoStep == 2 && FlashlightController.tl > 50)
        {
            transform.GetComponentInChildren<Text>().text = "Presser α1 pour allumer la lampe torche et α2 pour l'éteindre";
            TutoStep = 3;
        }
        if (TutoStep == 3 && FlashlightController.isactive == true)
        {
            TutoStep = 4;
            transform.GetComponentInChildren<Text>().text = "";
        }
        if(TutoStep == 4 && RaycastPerso.extincteur == true)
        {
            transform.GetComponentInChildren<Text>().text = "Appuie sur click gauche pour utiliser l'extincteur";
            TutoStep = 5;
        }
        if (TutoStep == 5 && FireController.ExtinctUse == true)
        {

            transform.GetComponentInChildren<Text>().text = "Appuie sur α1 pour prendre la lampe torche et α2 pour prendre l'extincteur";
            TutoStep = 6;
        }
        if(TutoStep == 6 && Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.GetComponentInChildren<Text>().text = "";
            TutoStep = 7;
        }

    }
}
