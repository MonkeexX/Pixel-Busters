using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform controladorDisparo;
    public GameObject bullet;
    public float intervaloDisparo = 5.0f; // Intervalo entre disparos en segundos
    private float tiempoUltimoDisparo; // Tiempo del �ltimo disparo

    // Start is called before the first frame update
    void Start()
    {
        // Establecer el tiempo del �ltimo disparo al inicio para permitir el primer disparo inmediatamente
        tiempoUltimoDisparo = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Verificar si ha pasado el tiempo suficiente desde el �ltimo disparo
        if (Time.time - tiempoUltimoDisparo >= intervaloDisparo)
        {
            Shoot(); // Disparar
            tiempoUltimoDisparo = Time.time; // Actualizar el tiempo del �ltimo disparo
        }
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, controladorDisparo.position, controladorDisparo.rotation);
        Destroy(newBullet.gameObject, 1.0f); // Destruir la bala despu�s de 1 segundo
    }
}