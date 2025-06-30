using UnityEngine;

public class PaddleRight : Paddle
{
    private Vector2 direction;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            rigidbody_2D.AddForce(direction * speed);
        }
    }
}
