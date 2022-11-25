using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] spawnPosition;

    void Start()
    {
        for(int i = 0; i < spawnPosition.Length; i++)
        {
            Instantiate(prefab, spawnPosition[Random.Range(0, spawnPosition.Length)].position, transform.rotation);
        }
    }

    void Update()
    {
        
    }
}
