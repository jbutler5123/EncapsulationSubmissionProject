using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cat : Animal
{
    //INHERITANCE - ANIMAL

    public GameObject vocalizeCanvas;
    public GameObject vocalizeText;
    
    
    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Vocalize()
    {
        //meow
        //Debug.Log("Meow");
        vocalizeCanvas.SetActive(true);
        vocalizeText.GetComponent<TMPro.TextMeshProUGUI>().text="Meow";

    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Walk()
    {
        speed=10;
        base.Walk();
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Run()
    {
        runMultiplier=2;
        base.Run();
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Jump()
    {
        Thrust=4;
        base.Jump();
    }

    
}
