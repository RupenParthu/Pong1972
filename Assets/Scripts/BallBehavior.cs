using System.Numerics;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float speed = 300f;
    private Rigidbody2D rigidbody2d;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    public void ballreset()
    {
        rigidbody2d.position = UnityEngine.Vector2.zero;
        rigidbody2d.linearVelocity = UnityEngine.Vector2.zero;
        startingForce();
    }

    public void startingForce()
    {
        float x = Random.value > 0.5 ? -1 : 1;
        float y = Random.value < 0.5 ? Random.Range(-1f, -0.3f) : Random.Range(0.3f, 1f);
        rigidbody2d.AddForce(new UnityEngine.Vector2(x, y) * speed);
    }
    private void Start()
    {
        ballreset();
    }
}
