using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform controladorDisparo;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       Shoot();
    }

    private void Shoot()
    {
        GameObject NewBullet = Instantiate(bullet, controladorDisparo.position, controladorDisparo.rotation);
        Destroy(NewBullet.gameObject, 1.0f);
    }
}