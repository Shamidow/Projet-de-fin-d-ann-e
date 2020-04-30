using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private bool ventolineCheck = false;
    private float timervento = 0f;
    public static int ventoline = 0;
    public GameObject flash;
    public GameObject fire;
    public AudioSource ventolineas;
    public AudioSource changewpn;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ventolineCheck == true)
        {
            Ventoline();
            timervento = timervento + Time.deltaTime;
            Debug.Log(PlayerHP.hp);
        }
        if(timervento >= 5f)
        {
            ventolineCheck = false;
            ventoline--;
            timervento = 0f;
        }
        if (Input.GetKeyDown(KeyCode.V) && ventolineCheck == false && ventoline != 0)
        {
            ventolineCheck = true;
            ventolineas.Play(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            fire.SetActive(false);
            flash.SetActive(true);
            changewpn.Play(0);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) && RaycastPerso.extincteur == true)
        {
            fire.SetActive(true);
            flash.SetActive(false);
            changewpn.Play(0);
        }
    }
    public void Ventoline()
    {
        PlayerHP.hp = PlayerHP.hp + 5 * Time.deltaTime;
    }
}
