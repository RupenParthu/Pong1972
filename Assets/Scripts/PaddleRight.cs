using UnityEngine;

public class PaddleRight : Paddle
{
    // private Vector2 direction;

    // void Update()
    // {
    //     if (Input.GetKey(KeyCode.UpArrow))
    //     {
    //         direction = Vector2.up;
    //     }
    //     else if (Input.GetKey(KeyCode.DownArrow))
    //     {
    //         direction = Vector2.down;
    //     }
    //     else
    //     {
    //         direction = Vector2.zero;
    //     }
    // }

    // void FixedUpdate()
    // {
    //     if (direction.sqrMagnitude != 0)
    //     {
    //         rigidbody_2D.AddForce(direction * speed);
    //     }
    // }
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.linearVelocity.x > 0f)
        {
            if (this.ball.position.y > this.transform.position.y) {
              rigidbody_2D.AddForce(Vector2.up * speed);
            } else if (ball.position.y < this.transform.position.y) {
              rigidbody_2D.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0f) {
              rigidbody_2D.AddForce(Vector2.down * speed);
            } else if (this.transform.position.y < 0f) {
              rigidbody_2D.AddForce(Vector2.up * speed);
            }
        }
    }
}
