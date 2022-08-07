using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    //ENCAPSULATION GETTER AND SETTER
    public float speed
    {
        get { return m_speed; } // getter returns backing field
        set 
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative speed!");
            }
            else
            {
            m_speed = value; // original setter now in if/else statement
            }
        }
    }
    private float m_speed=5.0f;

    //ENCAPSULATION GETTER AND SETTER
    public float runMultiplier
    {
        get { return m_runMultiplier; } // getter returns backing field
        set 
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative runMultiplier!");
            }
            else
            {
            m_runMultiplier = value; // original setter now in if/else statement
            }
        }
    }
    private float m_runMultiplier=1.0f;

    //ENCAPSULATION GETTER AND SETTER
    public float Thrust
    {
        get { return m_Thrust; } // getter returns backing field
        set 
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative Thrust!");
            }
            else
            {
            m_Thrust = value; // original setter now in if/else statement
            }
        }
    }
    private float m_Thrust=2.0f;
    private Rigidbody m_Rigidbody;

    //INHERITANCE - ABSTRACT METHOD TO BE OVERRIDDEN
    public abstract void Vocalize();

    //INHERITANCE - VIRTUAL METHOD CAN BE OVERRIDDEN
    public virtual void Run()
    {
        transform.Translate(Vector3.forward*m_speed*m_runMultiplier*Time.deltaTime);
    }
    
    //INHERITANCE - VIRTUAL METHOD CAN BE OVERRIDDEN
    public virtual void Walk()
    {
        transform.Translate(Vector3.forward*m_speed*Time.deltaTime);
    }

    //INHERITANCE - VIRTUAL METHOD CAN BE OVERRIDDEN
    public virtual void Jump()
    {
        m_Rigidbody.AddForce(transform.up * m_Thrust, ForceMode.Impulse);
    }
}
