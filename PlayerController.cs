using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] //can edit the class in Unity editor
public class MoveEvent : UnityEvent<float>{}

public class PlayerController : MonoBehaviour
{
    public MoveEvent XMove; //vars based on move event class
    public MoveEvent YMove;
    public UnityEvent onJumpPressed;
    public UnityEvent onFirePressed;

    //bool jumping = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            XMove.Invoke(Input.GetAxis("Horizontal")); //will send out axis as float when invoked
        }

        if (Input.GetButton("Vertical"))
        {
            YMove.Invoke(Input.GetAxis("Vertical"));
        }

        if (Input.GetButtonDown("Jump"))
        {
            onJumpPressed.Invoke(); //trigger
        }

        if (Input.GetButtonDown("Fire1"))
        {
            onFirePressed.Invoke(); //trigger
        }
    }

   
    public void Die() //disables Player Controller script so player can't move
    {
        GetComponent<PlayerController>().enabled = false;
    }

   
}
