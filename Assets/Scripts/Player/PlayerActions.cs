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
            // FindObjectOfType<AudioManager>().Play("Ventoline");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && RaycastPerso.torche == true) 
        {
            fire.SetActive(false);
            flash.SetActive(true);
            FlashlightController.isactive = true;
            FindObjectOfType<AudioManager>().Play("Change Weapon");
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) && RaycastPerso.extincteur == true)
        {
            fire.SetActive(true);
            flash.SetActive(false);
            FindObjectOfType<AudioManager>().Play("Change Weapon");
            FlashlightController.isactive = false;
        }
    }
    public void Ventoline()
    {
        PlayerHP.hp = PlayerHP.hp + 5 * Time.deltaTime;
    }
}
