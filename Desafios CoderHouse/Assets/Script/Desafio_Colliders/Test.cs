using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
  public float speed;
  public Vector3 Scale;
  public Vector3 OriginalScale;
  public bool verificar = false;
  public float time = 0;
  int rndX;
  int rndY;
  int rndZ;
  public GameObject objeto;

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
      transform.Rotate(new Vector3(0, -1f, 0));
    }

    if(Input.GetKey(KeyCode.E))
    {
      transform.Rotate(new Vector3(0, 1f, 0));
    }

    float movX = Input.GetAxis("Horizontal");
    float movY = Input.GetAxis("Vertical");
    transform.Translate(new Vector3(movX, 0, movY) * speed * Time.deltaTime);
  }

  void OnTriggerExit(Collider col) 
  {
    if(col.transform.gameObject.tag == "Portal")
    {
      if(verificar == true)
      {
        transform.localScale = Scale;
      } else if (verificar == false)
      {
        transform.localScale = OriginalScale;
      }
    }
  }

  void OnTriggerEnter(Collider col) 
  {
    if(verificar == false)
    {
      verificar = true;
    } else if(verificar = true)
    {
      verificar = false;
    } 
    Debug.Log("Portal");
  }

  void OnTriggerStay(Collider col) 
  {
    if(col.transform.gameObject.tag == "GoldenWall")
    {
      time += Time.deltaTime;
      if(time > 2)
      {
        Debug.Log("GoldenWall");
        rndX = Random.Range(-10, 10);
        rndY = Random.Range(-50, 50);
        rndZ = Random.Range(-10, 10);
        objeto.transform.position = new Vector3(rndX, 2.5f, rndZ);
        objeto.transform.rotation = Quaternion.Euler(0, rndY, 0);
        time = 0;

      }
    }
  }
 
}
