using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rigidbody_2D;
    public float speed = 10f;

    void Awake()
    {
        rigidbody_2D = GetComponent<Rigidbody2D>();
    }
}
