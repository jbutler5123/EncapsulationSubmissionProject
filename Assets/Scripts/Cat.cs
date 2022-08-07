using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    
    public override void Vocalize()
    {
        //meow
        Debug.Log("Meow");
    }

    public override void Walk()
    {
        speed/=2;
        base.Walk();
    }

    public override void Run()
    {
        runMultiplier*=2;
        base.Run();
    }

    public override void Jump()
    {
        Thrust*=2;
        base.Jump();
    }

    
}
