using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    public float bounciness = 1.3f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity *= bounciness;
        }
        
    }
}
