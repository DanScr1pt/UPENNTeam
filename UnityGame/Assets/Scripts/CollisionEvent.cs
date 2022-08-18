using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
    public UnityEvent OnCollide;
    public UnityEvent onPlayerCollide;
    public UnityEvent onEnemyCollide;
    public UnityEvent onBulletTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.CompareTag("Enemy"))
       {
            onPlayerCollide.Invoke();
            Debug.Log("Good kick!");
       }

       if(other.gameObject.tag == "Player")
       {
            onPlayerCollide.Invoke();
            Debug.Log("Good kick!");
       }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            onBulletTrigger.Invoke();
        }
        
       if(other.gameObject.tag == "Coin")
       {
            Destroy(other.gameObject);
       }
    }

}
