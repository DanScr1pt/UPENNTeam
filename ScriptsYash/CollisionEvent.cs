using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))] //require collider
public class CollisionEvent : MonoBehaviour
{
    //public UnityEvent OnCollide;
    public UnityEvent onPlayerCollide;
    //public UnityEvent onEnemyCollide;
    public UnityEvent onBulletTrigger;
    //public UnityEvent onCoinTrigger;

    private void OnCollisionEnter(Collision other) 
    {

        if (other.gameObject.CompareTag("Player"))
        {
            onPlayerCollide.Invoke(); //trigger
        }
        //OnCollide.Invoke(); //if tag is not player
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            onBulletTrigger.Invoke(); //trigger
        }

    }


   
}
