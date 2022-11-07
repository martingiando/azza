using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

public float speed;
public Vector3 direction;
public float damage;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        direction = new Vector3 (0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        
    }
}
