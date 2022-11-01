using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    private IEnemyAI enemyAI;

    [SerializeField]
    private LayerMask playerLayer;

    [SerializeField]
    private float detectionRadius;
    
    [SerializeField]
    private Transform radiusPos;

    [HideInInspector]
    public GameObject target;

    void Awake()
    {
        enemyAI = GetComponent<IEnemyAI>();
    }

    void FixedUpdate()
    {
        
        Collider2D[] colliderArray = Physics2D.OverlapCircleAll(radiusPos.position, detectionRadius, playerLayer);
        foreach (Collider2D collider in colliderArray)
        {
            target = collider.gameObject;

            enemyAI.EnemyDetected();
        }

    }

    //Debugging
    void OnDrawGizmosSelected()
    {
        if(radiusPos == null) return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(radiusPos.position, detectionRadius);
    }
}
