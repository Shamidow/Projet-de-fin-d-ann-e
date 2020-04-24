using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerHeight : MonoBehaviour
{
    public int touch = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {

        touch = 1;
        Debug.Log("touche");

    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("pas touche");
        touch = 0;

    }
}
