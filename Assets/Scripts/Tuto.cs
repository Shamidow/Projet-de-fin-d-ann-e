using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuto : MonoBehaviour
{
    public static int TutoStep = 0;
    private bool StepFiveSkip = false;
    private bool StepSixSkip = false;
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
            StepFiveSkip = false;
     StepSixSkip = false;
    transform.GetComponentInChildren<Text>().text = "Press 'A' several times to recharge the dynamo of the flashlight";
                TutoStep = 2;
            Debug.Log("To recharge the flashlight battery press A");
        }
        if (TutoStep == 2 && FlashlightController.tl > 50)
        {
            transform.GetComponentInChildren<Text>().text = "Press 'F' to turn the flashlight on or off";
            TutoStep = 3;
        }
        if (TutoStep == 3 && FlashlightController.isactive == true)
        {
            TutoStep = 4;
            transform.GetComponentInChildren<Text>().text = "";
        }
        if(TutoStep == 4 && RaycastPerso.extincteur == true)
        {
            transform.GetComponentInChildren<Text>().text = "Press 'Left Mouse Button' to use the extinguisher";
            TutoStep = 5;
            StartCoroutine(StepFive());
        }
        if (TutoStep == 5 && FireController.ExtinctUse == true || StepFiveSkip == true)
        {

            transform.GetComponentInChildren<Text>().text = "Press '&' to take the flashlight and 'é' to take the extinguisher";
            TutoStep = 6;
            StartCoroutine(StepSix());
        }
        if (TutoStep == 6 && StepSixSkip == true)
        {
            transform.GetComponentInChildren<Text>().text = "";
            TutoStep = 7;
        }
        if (TutoStep == 6 && Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.GetComponentInChildren<Text>().text = "";
            TutoStep = 7;
        }
        if (TutoStep == 7)
        {
            transform.GetComponentInChildren<Text>().text = "";
        }


        IEnumerator StepFive()
        {
            yield return new WaitForSeconds(6f);
            if(TutoStep == 5)
            {
             StepFiveSkip = true;
            }
            
        }
        IEnumerator StepSix()
        {
            yield return new WaitForSeconds(6f);
            if (TutoStep == 5)
            {
                StepSixSkip = true;
            }

        }
    }
}
