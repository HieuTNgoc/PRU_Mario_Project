using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerScript : MonoBehaviour
{
    public float Speed;
    public bool OnGround = true;
    public bool Turn  = false;

    private Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animation.SetFloat("Speed", Speed);
        animation.SetBool("OnGround", OnGround);
        animation.SetBool("Turn", Turn);

    }
}
