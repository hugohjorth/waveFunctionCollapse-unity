using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public bool isWater = false;
    Vector2 movement;

    void Update()
    {
        //Inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //Debug.Log("X pos: " + transform.position);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        //Movement
        if(!isWater) rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }


}
