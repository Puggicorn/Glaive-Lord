using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargerAI : MonoBehaviour, IEnemyAI
{
    [SerializeField]
    private EnemyDetection enemyDetection;

    //Components
    [SerializeField]
    private Transform enemyTransform;
    
    //Floats
    [SerializeField]
    float speed = 5f;
    [SerializeField]
    float chargeRadius = 5f;
    [SerializeField]
    float chargeDuration = 5f;
    [SerializeField]
    float chargeSpeed = 15f;

    private enum State {
        Idle,
        Chase,
        Charge,
        Rest,
        Stunned,
        None,
    }

    private State state;

    void Start()
    {
        state = State.Idle;
    }

    private Transform target;

    public void EnemyDetected()
    {
        target = enemyDetection.target.transform;
    }

    public Vector2 moveVector {get; set;}

    void FixedUpdate()
    {
        
        if(target == null)
        {
            state = State.Idle;
            moveVector = Vector2.zero;
        }

        switch (state)
        {
            

            case State.Idle:

                if(target != null)
                {
                    state = State.Chase;
                }
                
            break;

            case State.Chase:

                float dist = Vector2.Distance(enemyTransform.position, target.position);

                moveVector = (target.position - enemyTransform.position).normalized;
                moveVector *= speed;

                if(dist < chargeRadius)
                {
                    state = State.Charge;
                }

            break;

            case State.Charge:

                StartCoroutine(Charge(chargeDuration));
                state = State.None;

            break;

            case State.Rest:

                StartCoroutine(Stop(1, false));
                state = State.None;

            break;

            case State.Stunned:

                StartCoroutine(Stop(5, true));
                state = State.None;

            break;

            case State.None:
            break;

        }

    }

    IEnumerator Charge(float duration)
    {
        float elapsed = 0.0f;

        //Wait in place
        while(elapsed < 1f)
        {
            moveVector = Vector2.zero;

            elapsed += Time.deltaTime;

            yield return null;
        }

        elapsed = 0.0f;

        moveVector = (target.position - enemyTransform.position).normalized;
        moveVector *= chargeSpeed;

        //Charge at target
        while(elapsed < duration)
        {
            elapsed += Time.deltaTime;

            yield return null;
        }

        state = State.Rest;
    }

    IEnumerator Stop(float duration, bool IsStunned)
    {
        moveVector = Vector2.zero;

        float elapsed = 0.0f;

        while(elapsed < duration)
        {
            if(IsStunned)
            {
                //Stun effect here or smth
                Debug.Log("Stunned");
            }

            elapsed += Time.deltaTime;

            yield return null;
        }
        
        state = State.Chase;

        yield return null;

    }

    public void Knockback()
    {
        if(state != State.Charge) return;
        Stun();
    }

    public void Stun()
    {
        state = State.Stunned;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(enemyTransform.position, chargeRadius);
    }
}
