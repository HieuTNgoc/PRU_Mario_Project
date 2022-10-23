using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAble : MonoBehaviour
{
    public float Speed;
    public bool leftFirst = true;
    private void FixedUpdate()
    {
        Vector2 Move = transform.localPosition;
        if (leftFirst) Move.x -= Speed*Time.deltaTime;
        else Move.x += Speed*Time.deltaTime;

        transform.localPosition = Move;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag!="Player" && collision.contacts[0].normal.x > 0)
        {
            leftFirst = true;
            turn();
        }
        else if (collision.collider.tag != "Player" && collision.contacts[0].normal.x < 0)
        {
            leftFirst = false;
            turn();
        }
    }

    void turn()
    {
        leftFirst = !leftFirst;
        Vector2 direction = transform.localScale;
        direction.x *= -1;
        transform.localScale = direction;
    }
}
