using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] //requires rigid body

public class CharacterMover : MonoBehaviour
{
    Rigidbody rb;
    float jumpForce = 5.0f; //change the size to alter jump height
    public bool jumping = false;

    public float speed = 10;

    public float counter = 0;
    public float limit = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    public void IncrementLimit()
    {
        limit++;
    }

    public void Jump()
    {
        if (counter < limit)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumping = true;
            counter++;
        }
        if (counter > limit)
        {
            Debug.Log("stop jumping");
            jumping = false;
            return;
        }
        return;
    }

    public void MoveLeftRight(float axis)
    {
        //Debug.Log("Horizontal: " + axis);
        transform.Translate(Vector3.right * speed * Time.deltaTime * axis);
    }

    public void MoveForwardBackward(float axis)
    {
        //Debug.Log("Vertical: " + axis);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * axis);
    }

    private void OnCollisionEnter(Collision other)
    {
        /** if (other.gameObject.tag == "Player")
        {
            onPlayerCollide.Invoke(); //trigger
        }
        **/

        if (other.gameObject.tag == "Ground")
        {
            jumping = false;
            counter = 0;
        }

        if (Input.GetButtonDown("Jump") && jumping == false) //limit jumps
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumping = true;
        }
        
    }
}
