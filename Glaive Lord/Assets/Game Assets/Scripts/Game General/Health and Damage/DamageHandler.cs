using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    [Header("Components")]
    [SerializeField]
    private GameObject InstanceChild;
    [SerializeField]
    private EnemyController enemyController;

    [Header("Health")]
    public int health = 1;

    [Header("Knockback")]
    public bool IsKnockbackImmune;
    [SerializeField]
    private float knockbackMultiplier = 1;

    [Header("iFrames")]
    public bool IsInvulnerable;
    [SerializeField] 
    private int numberOfFlashes;
    [SerializeField]
    private SpriteRenderer spriteRend;

    public void Damage(int damage, Vector2 knockbackVector, Vector3 damageSource, float iFramesDuration)
    {   
        if(IsInvulnerable) return;
        
        health -= damage;

        //Damage Indicator
        if(!gameObject.CompareTag("Player"))
        {
            
            bool IsCritical;
            if(damage >= 5)
            {
                IsCritical = true;
            } 
            else
            {
                IsCritical = false;
            }

            DamageIndicatorScript.Instance.CreateIndicator(InstanceChild.transform.position, damage, IsCritical);

            //Knockback
            if(!IsKnockbackImmune)
            {
                StartCoroutine(KnockBack(knockbackVector));
            }
            
        }

        //Death effects and object removal
        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if(iFramesDuration > 0) StartCoroutine(Invulnerability(iFramesDuration, numberOfFlashes));

    }
    private IEnumerator Invulnerability(float iFramesDuration, int numberOfFlashes)
    {
        IsInvulnerable = true;
        for(int i = 0; i < numberOfFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
        }
        IsInvulnerable = false;

        yield return null;
    }

    IEnumerator KnockBack(Vector3 moveDirection)
    {
        float elapsed = 0.0f;

        while (elapsed < 0.1f)
        {
            enemyController.knockbackVector = moveDirection * knockbackMultiplier;

            elapsed += Time.deltaTime;

            yield return null;
        }

        enemyController.knockbackVector = Vector2.zero;

        yield return null;
    }
}
