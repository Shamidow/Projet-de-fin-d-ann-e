using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public static float hp = 100, xMin = 0, xMax = 100;
    private bool trigger;
    public AudioSource death;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (trigger == true)
            {
                hp = hp - 3 * Time.deltaTime;
                Debug.Log(hp);
                
            }
        
        if(hp <= 0)
        {
            Destroy(gameObject);
            death.Play(0);
        }
        hp = Mathf.Clamp(hp, 0, 100);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cloud"))
        {
            trigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cloud"))
        {
            trigger = false;
        }
    }
}
