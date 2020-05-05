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
    public GameObject disablecrosshair;
    public AudioSource touche;
    public AudioSource correct;
    //  public Texture2D cursorArrow;
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
          //  cursorbutton.transform.position = Cursor.position;
            DetectKey();
        }
            if (Input.GetKeyUp(KeyCode.E) && enter == true && iskeying == false)
            {
            Screen.lockCursor = true;

            FPSController.gameObject.SetActive(false);
            disablecrosshair.gameObject.SetActive(false);
                transform.GetChild(0).gameObject.SetActive(true);
                iskeying = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;

        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.Auto);

            }
            else
            if (Input.GetKeyUp(KeyCode.E) && iskeying == true)
        {
            
            disablecrosshair.gameObject.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(false);
            FPSController.gameObject.SetActive(true);
            Cursor.visible = false;
            iskeying = false;
        }
    }
    /*
    void OnMouseEnter()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    void OnMouseExit()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }*/



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

    public void writekeypad(int chara)
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
            FindObjectOfType<AudioManager>().Play("Code Bon");
            PowerGoodCode = true;
            Debug.Log("Le Code est bon");
        }
    }

}
