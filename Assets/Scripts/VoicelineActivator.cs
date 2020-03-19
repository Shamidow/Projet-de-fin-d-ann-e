using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicelineActivator : MonoBehaviour
{
    public GameObject voiceline;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(Instantiate(voiceline), 10f);
            voiceline.transform.parent = null;
            Destroy(gameObject);
        }
    }
}
