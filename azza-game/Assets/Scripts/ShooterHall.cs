using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterHall : MonoBehaviour
{
   
	public GameObject bala2;
	public Transform cannonPos;

	public float timer = 1f;

    private void Update()
    {
		timer -= Time.deltaTime;

		if (timer <= 0)
		{
			Shoot();
			timer = 1f;
		}
	}

	
	private void Shoot()
	{
		Instantiate(bala2, cannonPos.position, cannonPos.rotation);
		
	}
}


