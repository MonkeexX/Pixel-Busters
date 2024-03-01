using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamege : MonoBehaviour
{
    public int quantity = 15;
    private characterHealth_and_Damage enemyD;
    private void Start()
    {
        enemyD = GetComponent<characterHealth_and_Damage>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<characterHealth_and_Damage>().RestHealth(quantity);
        }
    }
}
