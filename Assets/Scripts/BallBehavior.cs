using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float speed = 300f;
    private Rigidbody2D rigidbody2d;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        float x = Random.value > 0.5 ? -1 : 1;
        float y = Random.value < 0.5 ? Random.Range(-1f, -0.3f) : Random.Range(0.3f, 1f);
        rigidbody2d.AddForce(new Vector2(x, y) * speed);                                                            
    }
}
