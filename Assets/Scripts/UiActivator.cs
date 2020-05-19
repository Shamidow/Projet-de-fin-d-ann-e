using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiActivator : MonoBehaviour
{
    public GameObject E1;
    public GameObject E2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        E1.SetActive(true);
        E2.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        E1.SetActive(false);
        E2.SetActive(false);
    }
}
