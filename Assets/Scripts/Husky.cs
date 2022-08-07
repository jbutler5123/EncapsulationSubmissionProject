using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Husky : Dog
{
    //INHERITANCE - ANIMAL -> DOG
    public override void Vocalize()
    {
        //POLYMORPHISM - OVERRIDES DOG AND ANIMAL
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("OOOOOOOOOOOOOooooooooooooooooooooooooooo");
            base.Vocalize();
        }
        
    }
}
