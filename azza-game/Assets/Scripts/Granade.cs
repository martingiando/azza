using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{

    public Transform target;

    public EnemyType enemyType;

    public float Damage;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyType)
        {
            case EnemyType.Normal:
                Damage = 30f;
                break;
            case EnemyType.Fire:
                Damage = 50f;
                break;
            case EnemyType.Ice:
                Damage = 20f;
                break;
        }

    }

    public enum EnemyType
    {
        Normal,
        Fire,
        Ice
        
    }
}

