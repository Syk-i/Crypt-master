using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    public int Amount;
    public int HealthPoints;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == true)
        {
            Debug.Log("They are touching");
        }
        else
        {
            Debug.Log("Nope");
        }
    }
}
            
            

 
   

