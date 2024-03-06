using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterHealth_and_Damage : MonoBehaviour
{
    public int health = 100;
    
    public void RestHealth(int quantity)
    {
        health -= quantity;
    }
}
