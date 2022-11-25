using UnityEngine;

public class Clases : MonoBehaviour
{
    public int life;
    public string name;
    public float damage;

    public void Information()
    {
        Debug.Log("Type: " + name + " Life: " + life + " Damage: " + damage);
    }

    public virtual void Attack()
    {
        Debug.Log("Has atacado");
    }
}



