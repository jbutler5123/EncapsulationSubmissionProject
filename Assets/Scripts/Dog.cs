using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public override void Vocalize()
    {
        //bark
        Debug.Log("Bark");
    }
    public override void Jump()
    {
        Thrust/=2;
        base.Jump();
    }
}
