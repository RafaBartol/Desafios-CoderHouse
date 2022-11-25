using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDeUnObjeto : MonoBehaviour
{
    public Vector3 Scale;
    public float PosicionX;
    public float PosicionY;
    public float PosicionZ;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Scale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(PosicionX, PosicionY, PosicionZ) * Speed * Time.deltaTime;
    }
}
