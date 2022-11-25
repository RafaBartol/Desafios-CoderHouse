using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instacia;

    void Awake() 
    {
        if(Singleton.instacia == null)
        {
            Singleton.instacia = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
