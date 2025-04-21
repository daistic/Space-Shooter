using UnityEngine;
using UnityEngine.InputSystem;

public class TestPlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public float shootDelay;

    [SerializeField] GameObject bullet;

    private TestPlayerInput playerInput;
    private Rigidbody2D rb2D;
    private float shootTime = 0f;

    private void Awake()
    {
        playerInput = new TestPlayerInput();

        playerInput.Game.Enable();
        playerInput.Game.Shoot.performed += OnShoot;
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2D.linearVelocityX = moveSpeed * playerInput.Game.Move.ReadValue<float>();
    }

    private void OnShoot(InputAction.CallbackContext ctx)
    {
        Debug.Log(shootDelay);
        if (Time.time > shootTime)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            shootTime = Time.time + shootDelay;
        }
    }
}
