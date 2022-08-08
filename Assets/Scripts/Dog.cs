using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dog : Animal
{
    //INHERITANCE - ANIMAL

    public GameObject vocalizeCanvas;
    public GameObject vocalizeText;

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Vocalize()
    {
        //bark
        //Debug.Log("Bark");
        vocalizeCanvas.SetActive(true);
        vocalizeText.GetComponent<TMPro.TextMeshProUGUI>().text="Bark";
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Jump()
    {
        Thrust=1;
        base.Jump();
    }
}
