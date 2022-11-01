using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private IEnemyAI enemyAI;

    [SerializeField]
    private Movement movement;

    void Awake()
    {
        enemyAI = GetComponentInParent<IEnemyAI>();
    }

    public Vector2 knockbackVector;

    void Update()
    {
        Vector2 AIMoveVector = Vector2.zero;
        if(enemyAI != null) AIMoveVector = enemyAI.moveVector;

        if(knockbackVector == Vector2.zero)
        {
            movement.moveDirection = AIMoveVector;
        }
        else
        {
            movement.moveDirection = knockbackVector;
        }
        
    }
}
