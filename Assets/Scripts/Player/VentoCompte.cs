using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VentoCompte : MonoBehaviour
{
    public Text VentoText;
    public RaycastPerso perso;

    // Start is called before the first frame update
    void Start()
    {
        VentoText = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        VentoText.text = "0" + RaycastPerso.Ventolines;
    }
}
