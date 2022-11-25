using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float vidaEnemigo = 100f;
    public GameObject explosion;

    void Update()
    {
        if(vidaEnemigo <= 0)
        {
            Kills.Muertos++;
            Destroy(gameObject);
            GameObject exp = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject, 3f);
        }


    }
}
