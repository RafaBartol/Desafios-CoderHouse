using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<int> numbers = new List<int>();

    void Start()
    {
        numbers.Add(1);
        numbers.Add(2);

        for(int i = 4; i >= 0; i--)
        {
            Debug.Log("Se han acabado los numeros");
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            numbers.Add(3);
        }

         if(Input.GetKeyDown(KeyCode.L))
        {
            numbers.Insert(3, 4);
        }
    }
}
