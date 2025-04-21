using UnityEngine;

public class TestBullet : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2D.linearVelocityY = speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
