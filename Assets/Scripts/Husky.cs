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
        StartCoroutine(Howl());
        
    }

    IEnumerator Howl()
    {
        for (int i = 0; i < 3; i++)
        {
            //Debug.Log("OOOOOOOOOOOOOooooooooooooooooooooooooooo");
            huskyVocalizeCanvas.SetActive(true);
            huskyVocalizeText.GetComponent<TMPro.TextMeshProUGUI>().text="OOOOOOOOOOOOOooooooooooooooooooooooooooo";
            yield return StartCoroutine(Wait());
            base.Vocalize();
            yield return StartCoroutine(Wait());
        }
    }
}
