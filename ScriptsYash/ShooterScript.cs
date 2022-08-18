using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShooterScript : MonoBehaviour
{
    public GameObject bullet;
    public UnityEvent onShoot;

    public bool canShoot;
    public float timeBetweenShots = 5;
    private float timeUntilNextShot;

    private void Update()
    {
        if (Time.time > timeUntilNextShot) //if game time has surpassed time you can shoot again
        {
            canShoot = true;
        }
    }

    public void Shoot()
    {
        onShoot.Invoke(); //trigger
    }

    public void Fire()
    {
        if(canShoot == true)
        {
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            canShoot = false; //can't shoot right after bullet is shot
            timeUntilNextShot = Time.time + timeBetweenShots;
        }
       
    }
}

