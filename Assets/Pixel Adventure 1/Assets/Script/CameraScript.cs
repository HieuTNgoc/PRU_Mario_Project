using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform Player;
    private float minX = 28, maxX = 295;
    private float minY = 7, maxY = 28;


    private void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        if (Player != null)
        {
            Vector3 position = transform.position;
            position.x = Player.position.x;
            position.y = Player.position.y;
            
            transform.position = position;
        }
    }
}
