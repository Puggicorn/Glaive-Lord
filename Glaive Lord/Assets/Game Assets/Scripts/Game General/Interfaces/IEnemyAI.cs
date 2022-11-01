using UnityEngine;
public interface IEnemyAI
{
    public void EnemyDetected();

    public void Knockback();

    public Vector2 moveVector {get; set;}
}