using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rb;

    public int damage;

    [SerializeField]
    private float iFrames = 1;
    
    [SerializeField]
    private bool doesKnockback;

    [SerializeField]
    private bool knockbackDamageScaling;

    [SerializeField]
    float knockbackMultiplier = 1f;

    public string targetTag = "Untagged";

    public Vector2 knockbackVector;

    void OnTriggerEnter2D(Collider2D targetObj)
    {     
        if(damage <= 0) return;

        if(doesKnockback)
        {
            if(knockbackDamageScaling)
            {
                knockbackVector = rb.velocity.normalized * damage;
            }
            else
            {
                knockbackVector = rb.velocity;
            }

            knockbackVector *= knockbackMultiplier;
        }

        if(targetObj.GetComponent<Damageable>() != null && targetObj.CompareTag(targetTag))
        {
            targetObj.gameObject.GetComponent<Damageable>().Damage(damage, knockbackVector, transform.position, iFrames);
        }
    }
}
