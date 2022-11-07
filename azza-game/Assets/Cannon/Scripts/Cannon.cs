using UnityEngine;

public class Cannon : MonoBehaviour
{
	public GameObject bala;
	public Transform cannonPos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
    }
	
	private void Shoot()
	{
		Instantiate(bala, cannonPos.position, cannonPos.rotation);
		Debug.Log("The Cannon has been shoot!");
	}
}
