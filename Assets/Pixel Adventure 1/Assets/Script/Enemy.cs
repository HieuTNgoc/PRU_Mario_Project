using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject Player;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player"); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" && (collision.contacts[0].normal.x > 0 || collision.contacts[0].normal.x < 0))
        {
            Player.GetComponent<MainPlayerScript>().GameOver();
        }
    }
}
