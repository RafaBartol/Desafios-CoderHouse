using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour
{
	public GameObject objetoAInstanciar;
    public Transform lugar;
	public float timeLeft;
	public float resetTime;

    private void Update()
    { 
		MultipleShoots();
		Timer();
	}

	private void MultipleShoots()
	{
		if (Input.GetKeyDown(KeyCode.J)){
			StartCoroutine(Disparo(2));
		}
		if (Input.GetKeyDown(KeyCode.K)){
			StartCoroutine(Disparo(3));
		}
		if (Input.GetKeyDown(KeyCode.L)){
			StartCoroutine(Disparo(4));
		}
	}
	
	IEnumerator Disparo(int repeticiones)
	{
		for (int i=0; i<repeticiones; i++) {
			Shoot();
			yield return new WaitForSeconds(0.2f);
		}
	}
	
	private void Shoot()
	{
		Instantiate(objetoAInstanciar,lugar.position,transform.rotation);
		Debug.Log("The Cannon has been shoot!");
	}

	private void Timer()
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0) 
		{
			Shoot();
			timeLeft = resetTime;
		}
	}

}
