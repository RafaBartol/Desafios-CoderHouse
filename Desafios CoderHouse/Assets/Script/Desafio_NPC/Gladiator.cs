using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator : MonoBehaviour
{
    public float speed;
    public GameObject Panoramic;
    public GameObject ThirdPerson;

    void Start()
    {
        
    }

    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -2f, 0));
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 2f, 0));
        }
        
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(movX, 0, movY) * speed * Time.deltaTime);
    }
}
