using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    // [Range(1, 5)]
    public static bool PowerGoodCode = false;
    private GameObject FPSController;
    public string code;
    private bool enter = false;
    private bool iskeying = false;
    private int charnum = 0;
    private string newchar;
    private string typedcode = "";
    private KeyCode[] button;
    // Start is called before the first frame update
    void Start()
    {
        
        button = new KeyCode[12];
        button[0] = KeyCode.Keypad0;
        button[1] = KeyCode.Keypad1;
        button[2] = KeyCode.Keypad2;
        button[3] = KeyCode.Keypad3;
        button[4] = KeyCode.Keypad4;
        button[5] = KeyCode.Keypad5;
        button[6] = KeyCode.Keypad6;
        button[7] = KeyCode.Keypad7;
        button[8] = KeyCode.Keypad8;
        button[9] = KeyCode.Keypad9;
        button[10] = KeyCode.A;
        button[11] = KeyCode.C;
    }

    // Update is called once per frame
    void Update()
    {
        // VerifyCode();
        
        if (iskeying == true)
        {
            DetectKey();
        }
            if (Input.GetKeyUp(KeyCode.E) && enter == true && iskeying == false)
            {
                FPSController.gameObject.SetActive(false);
                transform.GetChild(0).gameObject.SetActive(true);
                iskeying = true;
            }
            else
            if (Input.GetKeyUp(KeyCode.E) && iskeying == true)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            FPSController.gameObject.SetActive(true);
            iskeying = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FPSController = other.gameObject;
            enter = true;
            
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = false;

        }

    }

    void DetectKey()
    {
        for(int i = 0;i<12;i++)
        { 
          if(Input.GetKeyUp(button[i]))
          {
                writekeypad(i);
                break;
          }
        }
    }

    void writekeypad(int chara)
    {
        //SON : taper une touche
        newchar = "";
        if(chara == 10)
        {
            newchar = "A";
        }
        else
        if (chara == 11 )
        {
            typedcode = "";
            charnum = 0;
        }
        else
        {
           newchar = chara.ToString();
        }
        
        typedcode = typedcode + newchar;
        if (chara != 11)
        {
         charnum++;
        }
            
         VerifyCode();
        transform.GetChild(0).GetChild(0).gameObject.GetComponentInChildren<Text>().text = typedcode;
        if (charnum >= 5)
        {
            typedcode = "";
            charnum = 0;
        }
        
     //   Debug.Log(typedcode);
    }

    void VerifyCode()
    {
        
      if (typedcode == code)
        {
            // SON: Code correct
            PowerGoodCode = true;
            Debug.Log("Le Code est bon");
        }
    }

}
