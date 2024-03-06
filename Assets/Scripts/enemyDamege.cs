using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamege : MonoBehaviour
{
    public int quantity = 15;
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<characterHealth_and_Damage>().health -= quantity;
        }
    }
}
