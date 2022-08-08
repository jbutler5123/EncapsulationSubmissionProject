using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Husky : Dog
{
    //INHERITANCE - ANIMAL -> DOG

    public GameObject huskyVocalizeCanvas;
    public GameObject huskyVocalizeText;
    public override void Vocalize()
    {
        //POLYMORPHISM - OVERRIDES DOG AND ANIMAL
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("OOOOOOOOOOOOOooooooooooooooooooooooooooo");
            huskyVocalizeCanvas.SetActive(true);
            huskyVocalizeText.GetComponent<TMPro.TextMeshProUGUI>().text="yap";
            base.Vocalize();
            
        }
        
    }
}
