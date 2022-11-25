using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed;
    public float damage;
    public Vector3 direction;
    public Vector3 scale;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        IncreaseScale();
    }

    private void IncreaseScale()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += scale * 2 * Time.deltaTime;
        }
    }

    
}
