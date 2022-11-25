using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImplementacionDeMecanica : MonoBehaviour
{
    public float life = 100;
    public float speed;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        HealPlayer();
        DamagePlayer();
    }

    void PlayerMovement()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void HealPlayer()
    {
        life++;
    }

    void DamagePlayer()
    {
        life--;
    }
}
