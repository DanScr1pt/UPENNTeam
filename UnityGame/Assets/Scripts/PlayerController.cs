using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MoveEvent : UnityEvent<float>{}
public class PlayerController : MonoBehaviour
{
    public MoveEvent XMove;
    public MoveEvent YMove;
    public UnityEvent onJumpPressed;
    public UnityEvent onFirePressed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            XMove.Invoke(Input.GetAxis("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            YMove.Invoke(Input.GetAxis("Vertical"));
        }
        if (Input.GetButtonDown("Jump"))
        {
            onJumpPressed.Invoke();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            onFirePressed.Invoke();
        }
    }

    public void Die()
    {
        GetComponent<PlayerController>().enabled = false;
    }

}
