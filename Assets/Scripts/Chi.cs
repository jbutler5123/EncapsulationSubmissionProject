using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chi : Dog
{
    public override void Vocalize()
    {
        //Yap
        Debug.Log("Yap");
    }

    public override void Walk()
    {
        speed/=2;
        base.Walk();
    }

    public override void Run()
    {
        runMultiplier/=2;
        base.Run();
    }
}
