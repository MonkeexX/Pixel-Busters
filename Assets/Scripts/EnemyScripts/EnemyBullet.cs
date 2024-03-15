using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float da�o;

    private Vector2 direccionDisparo; // Almacena la direcci�n en la que se dispar� la bala

    void Start()
    {
        // Almacenar la direcci�n de disparo en funci�n de la escala X del jugador al inicio
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        
        if (enemy != null && enemy.transform.localScale.x < 0)
        {
            direccionDisparo = Vector2.right;
        }
        else
        {
            direccionDisparo = -Vector2.right;
        }
    }

    void Update()
    {
        // Mover la bala en la direcci�n en la que se dispar� inicialmente
        transform.Translate(direccionDisparo * velocidad * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }
}