using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    [SerializeField] float speed;

    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2D.linearVelocityY = -speed;
    }


    //if rigidbody is set to kinematic, then collisions won't fire OnCollisionEnter2D unless the object is moved via physics
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Deadzones"))
        {
            Destroy(gameObject);
        }
    }
}
