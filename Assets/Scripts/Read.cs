using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Read : MonoBehaviour
{
    // [Range(1, 5)]

    public List<GameObject> Page = new List<GameObject>();

    private GameObject FPSController;
    public static bool isPausing = false;
    private bool enter = false;
    private bool iskeying = false;
    private int Pagenum = 0;
    private string newchar;
    // private GameObject[] Page;
    public GameObject disablecrosshair;
    /*  public GameObject Page1;
      public GameObject Page2;
      public GameObject Page3;
      public GameObject Page4;*/
    public bool SoundVoice = false;



    //  public Texture2D cursorArrow;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Page.Count);
        //Page = new GameObject[4];
        /*    Page[0] = NewPage[0];
            Page[1] = Page2;
            Page[2] = Page3;
            Page[3] = Page4;*/
        //button[4] = KeyCode.Keypad4;

    }

    // Update is called once per frame
    void Update()
    {
        if (isPausing == false)
        {
            if (iskeying == true)
            {
                transform.GetChild(1).gameObject.SetActive(true);
                Cursor.visible = true;
                if (Input.GetKeyUp(KeyCode.LeftArrow))
                {
                    Pagenum--;
                }
                if (Input.GetKeyUp(KeyCode.RightArrow))
                {
                    Pagenum++;
                }
                if (Pagenum <= -1)
                {
                    Pagenum = Page.Count - 1;
                }
                if (Pagenum >= Page.Count)
                {
                    Pagenum = 0;
                }
                ReadPage();

            }
            if (Input.GetKeyUp(KeyCode.E) && enter == true && iskeying == false)
            {
                Screen.lockCursor = true;
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(true);
                FPSController.gameObject.SetActive(false);

                disablecrosshair.gameObject.SetActive(false);
                // transform.GetChild(0).gameObject.SetActive(true);
                iskeying = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
                //int newscore = 10;
                bool newsstatus = false;
                Crouch.ControllerStatus = newsstatus;


            }
            else
            if (Input.GetKeyUp(KeyCode.E) && iskeying == true)
            {

                disablecrosshair.gameObject.SetActive(true);
                //   transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(false);
                FPSController.gameObject.SetActive(true);

                bool newsstatus = true;
                Crouch.ControllerStatus = newsstatus;
                Page[Pagenum].SetActive(false);
                Cursor.visible = false;
                iskeying = false;
            }
            else
            if (Input.GetKeyUp(KeyCode.E) && enter == true && iskeying == false && SoundVoice == false)
            {
                FindObjectOfType<AudioManager>().Play("VDigicode False");
                SoundVoice = true;
            }
        }
        else
        {

            transform.GetChild(1).gameObject.SetActive(false);
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

    void ReadPage()
    {
        for (int i = 0; i < Page.Count; i++)
        {
            if (i != Pagenum)
            {
                Page[i].SetActive(false);
            }
        }
        //SON : Changement de page
        Page[Pagenum].SetActive(true);
    }


    public void ButtonSwitch(string sens)
    {
        if (isPausing == false)
        {
            if (sens == "left")
            {
                Pagenum--;
            }
            if (sens == "right")
            {
                Pagenum++;
            }
            if (Pagenum <= -1)
            {
                Pagenum = Page.Count - 1;
            }
            if (Pagenum >= Page.Count)
            {
                Pagenum = 0;
            }
            ReadPage();
        }
    }
    IEnumerator CorrectCode()
    {

        yield return new WaitForSeconds(1f);

    }


}
