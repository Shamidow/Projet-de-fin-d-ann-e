using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFFStandby : MonoBehaviour
{
    public Animator ff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            ff.SetBool("Standby", true);
        }
    }
}
