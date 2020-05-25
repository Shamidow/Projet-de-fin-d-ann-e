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
    public bool isactive = false;
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
        
        if (iskeying == true)
        {
          //  cursorbutton.transform.position = Cursor.position;
            DetectKey();
        }
            if (Input.GetKeyUp(KeyCode.E) && enter == true && iskeying == false && RaycastPerso.cdm == true)
            {
            Screen.lockCursor = true;

            FPSController.gameObject.SetActive(false);
            disablecrosshair.gameObject.SetActive(false);
                transform.GetChild(0).gameObject.SetActive(true);
                iskeying = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            //int newscore = 10;
         bool newsstatus = false;
        Crouch.ControllerStatus = newsstatus;
            //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.Auto);

        }
            else
            if (Input.GetKeyUp(KeyCode.E) && iskeying == true)
            {
            
            disablecrosshair.gameObject.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(false);
            FPSController.gameObject.SetActive(true);
            bool newsstatus = true;
            Crouch.ControllerStatus = newsstatus;

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
        if (iskeying == true)
        {
            //SON : taper une touche
            FindObjectOfType<AudioManager>().Play("Digicode Keys");
            newchar = "";
            if (chara == 10)
            {
                newchar = "A";
            }
            else
            if (chara == 11)
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
            transform.GetChild(0).GetChild(0).gameObject.GetComponentInChildren<Text>().text = typedcode;
            VerifyCode();

            if (charnum >= 5)
            {
                typedcode = "";
                charnum = 0;
            }
        }
     //   Debug.Log(typedcode);
    }

    void VerifyCode()
    {
        
      if (typedcode == code)
        {

            StartCoroutine(CorrectCode());
        }
        else if (charnum >= 5)
        {

            StartCoroutine(WrongCode());
        }

    }

    IEnumerator CorrectCode()
    {
        iskeying = false;
        yield return new WaitForSeconds(1f);
             // SON: Code correct
            transform.GetChild(0).GetChild(0).gameObject.GetComponentInChildren<Text>().text = "Correct";
            FindObjectOfType<AudioManager>().Play("Correct Code");
            PowerGoodCode = true;
            Debug.Log("Le Code est bon");
        yield return new WaitForSeconds(1f);
        disablecrosshair.gameObject.SetActive(true);
        transform.GetChild(0).gameObject.SetActive(false);
        FPSController.gameObject.SetActive(true);
        bool newsstatus = true;
        Crouch.ControllerStatus = newsstatus;
        Cursor.visible = false;
        iskeying = false;
    }

    IEnumerator WrongCode()
    {
        iskeying = false;
        yield return new WaitForSeconds(1f);
transform.GetChild(0).GetChild(0).gameObject.GetComponentInChildren<Text>().text = "Wrong";
            FindObjectOfType<AudioManager>().Play("Wrong Code");
        yield return new WaitForSeconds(1.5f);
        transform.GetChild(0).GetChild(0).gameObject.GetComponentInChildren<Text>().text = "";
        iskeying = true;
    }

}
