using System.Collections;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public Transform PlayerPos;
    public float speed = 5f;

    public Behaviour behaviour;

    public enum Behaviour 
    {
        LookAt,
        Follow,
    };

    void Start()
    {
       
    }

    void Update()
    {
        switch(behaviour)
        {
            case Behaviour.LookAt:
            LookAtPlayer();
            break;

            case Behaviour.Follow:
            FollowPlayer();
            LookAtPlayer();
            break;

            default:
            break;
        }
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
