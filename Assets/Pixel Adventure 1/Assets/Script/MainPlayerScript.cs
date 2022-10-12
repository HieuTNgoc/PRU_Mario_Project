using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerScript : MonoBehaviour
{
    public float velocity;

    private float Speed = 0;
    private bool OnGround = true;
    private bool Turn  = false;
    private bool TurnRight = true;
    private Rigidbody2D rigidbody2d;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Speed);
        animator.SetBool("OnGround", OnGround);
        animator.SetBool("Turn", Turn);
        JumpUp();
    }

    private void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        float keyLeftRigth = Input.GetAxis("Horizontal");
        rigidbody2d.velocity = new Vector2(velocity*keyLeftRigth, rigidbody2d.velocity.y);
        Speed = Mathf.Abs(velocity*keyLeftRigth);
        if (keyLeftRigth > 0 && !TurnRight) CheckDirection(); 
        if (keyLeftRigth < 0 && TurnRight) CheckDirection();
    }

    void CheckDirection()
    {
        TurnRight = !TurnRight;
        Vector2 direction = transform.localScale;
        direction.x *= -1;
        transform.localScale = direction;
    }

    void JumpUp()
    {
        if (Input.GetKeyDown(KeyCode.X) && OnGround == true)
        {
            print("nhau");
        }
    }
}
