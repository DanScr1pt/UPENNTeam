using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5.0f); //delete bullet from code 5 secs after it was fired 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime); 

        //if bullet collides with soccer goal -> change to football scene (buildIndex 1)
        //if bullet collides with football goal -> change to soccer scene (buildIndex 0)
    }
}
