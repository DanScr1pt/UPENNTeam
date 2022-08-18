using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShooterScript : MonoBehaviour
{
    public UnityEvent onShoot;
    public GameObject bullet;

    public bool canShoot;
    public float timeBetweenShots = 1;
    private float timeUntilNextShot;

    private void Update()
    {
        if (Time.time > timeUntilNextShot)
        {
            canShoot = true;
        }
    }

    public void Shoot()
    {
        onShoot.Invoke();
    }

    public void Fire()
    {
        if(canShoot == true)
        {
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            canShoot = false;
            timeUntilNextShot = Time.time + timeBetweenShots;
        }
    }
                 void OnTriggerEnter(Collider other)
{
        if(other.gameObject.CompareTag("Coin"))
        {
        Destroy(other.gameObject);
        }
 }
}