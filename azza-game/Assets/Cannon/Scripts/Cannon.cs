using UnityEngine;

public class Cannon : MonoBehaviour
{
	public GameObject bala;
	public Transform cannonPos;

	public float timer = 2f;

    private void Update()
    {
		timer -= Time.deltaTime;

		if (timer <= 0)
		{
			Shoot();
			timer = 2f;
		}
	}

	
	private void Shoot()
	{
		Instantiate(bala, cannonPos.position, cannonPos.rotation);
		
	}
}
