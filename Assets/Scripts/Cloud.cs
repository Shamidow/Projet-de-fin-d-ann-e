using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.localScale = transform.localScale + new Vector3(0,1 * Time.deltaTime, 0.1*Time.deltaTime, 0.1*Time.deltaTime);            
    }
    private void FixedUpdate()
    {
        if (timer <= 120f)
        {
            transform.localScale = transform.localScale + new Vector3(0.001f, 0.001f, 0.001f);
            timer = timer + Time.deltaTime;
            //Debug.Log(timer);
        }
    }

}
