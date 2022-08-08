using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chi : Dog
{
    //INHERITANCE - ANIMAL -> DOG

    public GameObject chiVocalizeCanvas;
    public GameObject chiVocalizeText;
    //POLYMORPHISM - OVERRIDES DOG AND ANIMAL
    public override void Vocalize()
    {
        //Yap
        //Debug.Log("Yap");
        chiVocalizeCanvas.SetActive(true);
        chiVocalizeText.GetComponent<TMPro.TextMeshProUGUI>().text="yap";
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Walk()
    {
        speed=2.5f;
        base.Walk();
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Run()
    {
        runMultiplier=0.5f;
        base.Run();
    }
}
