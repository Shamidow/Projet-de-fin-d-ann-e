using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    //public string endmessage;
    public GameObject endmessage;
    // Start is called before the first frame update
    void Start()
    {
        endmessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerStay(Collider other)
    {
        endmessage.SetActive(true);
        //GameObject.Find("Canvas/Text").GetComponent<Text>().text = endmessage.ToString();
        Debug.Log("Yo");
        Application.Quit();
    }
}
