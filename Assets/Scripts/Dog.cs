using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    //INHERITANCE - ANIMAL

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Vocalize()
    {
        //bark
        Debug.Log("Bark");
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Jump()
    {
        Thrust/=2;
        base.Jump();
    }
}
