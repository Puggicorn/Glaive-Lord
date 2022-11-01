using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField]
    DamageHandler damageHandler;
    
    [SerializeField]
    private int flatDamageReduction;

    public void Damage(int damage, Vector2 knockbackVector, Vector3 damageSource, float iFrames)
    {
        //Process damage information
        if(damage - flatDamageReduction < 0) return;

        damageHandler.Damage(damage, knockbackVector, damageSource, iFrames);
    }
}
