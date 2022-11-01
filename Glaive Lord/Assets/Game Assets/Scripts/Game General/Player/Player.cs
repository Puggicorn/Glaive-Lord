using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private HealthBar healthBar;
    [SerializeField]
    private DamageHandler damageHandler;

    void Start()
    {
        int maxHealth = damageHandler.health;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        int currentHealth = damageHandler.health;
        healthBar.SetHealth(currentHealth);
    }
}
