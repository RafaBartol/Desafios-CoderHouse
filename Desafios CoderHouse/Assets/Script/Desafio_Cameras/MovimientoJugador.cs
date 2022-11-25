using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float speed;
    public GameObject FirstPerson;
    public GameObject ThirdPerson;
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Song3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Radio();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Camera();
        }
    }

    void Radio()
    {
       if(Input.GetKeyDown(KeyCode.Z))
       {
        Song1.SetActive(true);
        Song2.SetActive(false);
        Song3.SetActive(false);
       }

       if(Input.GetKeyDown(KeyCode.X))
       {
        Song1.SetActive(false);
        Song2.SetActive(true);
        Song3.SetActive(false);
       }

       if(Input.GetKeyDown(KeyCode.C))
       {
        Song1.SetActive(false);
        Song2.SetActive(false);
        Song3.SetActive(true);
       }
    }
    void Camera()
    {
        if(FirstPerson.activeInHierarchy)
        {
            FirstPerson.SetActive(false);
            ThirdPerson.SetActive(true);
        } else
        {
            FirstPerson.SetActive(true);
            ThirdPerson.SetActive(false);
        }
    }

    void Movimiento()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -0.5f, 0));
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0.5f, 0));
        }
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(movX, 0, movY) * speed * Time.deltaTime);
    }
}
