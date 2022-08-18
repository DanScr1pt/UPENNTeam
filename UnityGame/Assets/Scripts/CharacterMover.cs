using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] 
public class CharacterMover : MonoBehaviour
{
    public float speed = 10;
    Rigidbody rb;
    float jumpForce = 8.0f;
    bool jumping = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        jumping = true;
    }

    public void MoveLeftRight(float axis)
    {
        Debug.Log("Horizontal: "+axis);
        transform.Translate(Vector3.right * speed * Time.deltaTime * axis);
    }

    public void MoveForwardBack(float axis)
    {
        Debug.Log("Vertical: " + axis);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * axis);
    }

    public void OnCollisionEnter(Collision other)
    {
        /**if(other.gameObject.tag == "Player")
       {
            onPlayerCollide.Invoke();
       }
       onCollide.Invoke();
        **/

       if(other.gameObject.tag == "Ground")
       {
           jumping = false;
       }

       if(Input.GetButtonDown("Jump") && jumping == false)
       {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumping = true;
       }
    }
}
