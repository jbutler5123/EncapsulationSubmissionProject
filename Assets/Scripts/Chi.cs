using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chi : Dog
{
    //INHERITANCE - ANIMAL -> DOG
    //POLYMORPHISM - OVERRIDES DOG AND ANIMAL
    public override void Vocalize()
    {
        //Yap
        Debug.Log("Yap");
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Walk()
    {
        speed/=2;
        base.Walk();
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Run()
    {
        runMultiplier/=2;
        base.Run();
    }
}
