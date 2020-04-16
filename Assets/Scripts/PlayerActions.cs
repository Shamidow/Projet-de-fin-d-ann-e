using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            Ventoline();
        }
    }
    public void Ventoline()
    {
        PlayerHP.hp = PlayerHP.hp + 5 * Time.deltaTime;
    }
}
