using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    //INHERITANCE - ANIMAL
    
    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Vocalize()
    {
        //meow
        Debug.Log("Meow");
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
        runMultiplier*=2;
        base.Run();
    }

    //POLYMORPHISM - OVERRIDES ANIMAL
    public override void Jump()
    {
        Thrust*=2;
        base.Jump();
    }

    
}
