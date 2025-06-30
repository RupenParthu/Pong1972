using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PaddleLeft : Paddle
{
    private Vector2 direction;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
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
