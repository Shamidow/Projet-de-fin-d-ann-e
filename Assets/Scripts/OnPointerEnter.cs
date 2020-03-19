using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro; // Besoin de ces deux trucs pour le highlight

public class OnPointerEnter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    TextMeshProUGUI textButton;
    void Start()
    {
        if (textButton == null)
        {
            textButton = GetComponentInChildren<TextMeshProUGUI>(); // Prends le texte dans l'enfant 

            textButton.faceColor = new Color32(255, 255, 255, 150); // Couleur de base
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnPointerExit(PointerEventData eventData)
    {
        textButton.faceColor = new Color32(255, 255, 255, 150); // Quand la souris part revient a la couleur de base 
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        textButton.faceColor = new Color32(255, 255, 255, 255); // Lumineux quand le pointeur 
    }
}
