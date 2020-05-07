using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnParticleCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    OnParticleCollider()
    {

            PlayerHP.hp--;
            Debug.Log("Les HPs baissent grâce aux particules" + PlayerHP.hp);
        
    }
}
