using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Husky : Dog
{
    public override void Vocalize()
    {
        //bark
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("OOOOOOOOOOOOOooooooooooooooooooooooooooo");
            base.Vocalize();
        }
        
    }
}
