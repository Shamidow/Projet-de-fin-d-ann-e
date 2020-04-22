using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private bool ventolineCheck = false;
    private float timervento = 0f;
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
            timervento = 0f;
        }
        if (Input.GetKeyDown(KeyCode.V) && ventolineCheck == false)
        {
            ventolineCheck = true;
        }
    }
    public void Ventoline()
    {
        PlayerHP.hp = PlayerHP.hp + 5 * Time.deltaTime;
    }
}
