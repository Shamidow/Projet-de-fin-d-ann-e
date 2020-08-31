using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatBox : MonoBehaviour
{
    public static string SetMessage = "";
    public float DelayBeforeDelete = 12f;
    public static bool ChatUpdated = false;
    private string[] SetMessagenum;
    private int[] DisplayTime;
    private int num = 1;
    private bool isDisplaying = false;

     /*public GameObject line1;
     public GameObject line2;
     public GameObject line3;
     public GameObject line4;*/
    // Start is called before the first frame update
    void Start()
    {
        DisplayTime = new int[3];
        DisplayTime[1] = 0;
        DisplayTime[2] = 0;
        SetMessagenum = new string[3];
        SetMessagenum[0] = "";
        SetMessagenum[1] = "";
        SetMessagenum[2] = "";
        //    line1 = GameObject.Find("Line1").GetComponentInChildren<Text>().text;

         GameObject.Find("Line1").GetComponentInChildren<Text>().text = "Founded";
    }

    // Update is called once per frame
    void Update()
    {

        if(num ==1)
        {
         GameObject.Find("Line1").GetComponentInChildren<Text>().text = SetMessagenum[1];
        GameObject.Find("Line2").GetComponentInChildren<Text>().text = SetMessagenum[2];      
        }
        else
        {
            GameObject.Find("Line1").GetComponentInChildren<Text>().text = SetMessagenum[2];
            GameObject.Find("Line2").GetComponentInChildren<Text>().text = SetMessagenum[1];
        }
        //Debug.Log(isDisplaying);
       // Debug.Log(GameObject.Find("Line1").GetComponentInChildren<Text>().text);
        if(ChatUpdated == true)
        {
            ChatUpdated = false;
         //Debug.Log("update");
            if(isDisplaying == true)
            {
             num++;
            if(num > 2)
            {
                num = 1;
            }
            }
            StartCoroutine(DisplayMessage(num));

        }


    }

 

    IEnumerator DisplayMessage(int line_n)
    {
        isDisplaying = true;
        DisplayTime[line_n]++;
        SetMessagenum[line_n] = SetMessage;
        yield return new WaitForSeconds(DelayBeforeDelete);
        if(DisplayTime[line_n] <= 1)
        {     
        SetMessagenum[line_n] = "";
        }
        DisplayTime[line_n]--;
        isDisplaying = false;
    }
}
