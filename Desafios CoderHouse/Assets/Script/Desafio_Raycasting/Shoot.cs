using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float range = 100f;
    public Camera FpsCam;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        RaycastHit hit;
        if(Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out hit, range))
        {
            if(hit.transform.tag == "Enemigo")
            {
                hit.transform.gameObject.GetComponent<Enemy>().vidaEnemigo -= 5f;
                Debug.Log("Le has dado a un enemigo");
                
            }
        }
    }
}
