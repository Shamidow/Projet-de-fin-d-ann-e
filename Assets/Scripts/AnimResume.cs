using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class AnimResume : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LaunchAnim()
    {
        Debug.Log("inchallah");
        anim.SetBool("Anim", true);
    }

    public void StopAnim()
    {
        anim.SetBool("Anim", false);
    }
}
