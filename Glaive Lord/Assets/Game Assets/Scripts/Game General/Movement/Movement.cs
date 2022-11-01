using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    
    public Vector2 moveDirection;

    private void FixedUpdate()
    {
        Vector2 move = moveDirection * 100;
        rb.velocity = new Vector2(move.x * Time.fixedDeltaTime, move.y * Time.fixedDeltaTime);
    }

}
