using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public Transform PlayerPos;
    public float speed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        FollowPlayer();
        LookAtPlayer();
        DistanceBetweenPlayer();
    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos.position, speed * Time.deltaTime);
    }

    void DistanceBetweenPlayer()
    {
        float dist = Vector3.Distance(PlayerPos.position, transform.position);  

        if(dist < 2)
        {
            speed = 0f;
        } else
        {
            speed = 5f;
        }
    }

     void LookAtPlayer()
    {
        transform.LookAt(PlayerPos);
    }

}
