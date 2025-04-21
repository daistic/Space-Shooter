using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float shootDelay;

    [SerializeField] GameObject bullet;

    private PlayerInput playerInput;
    private Rigidbody2D rb2d;
    private float delayTime;

    private void Awake()
    {
        playerInput = new PlayerInput();

        playerInput.Game.Enable();
        playerInput.Game.Shoot.canceled += OnShoot;
    }

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2d.linearVelocityX = moveSpeed * playerInput.Game.Move.ReadValue<float>();
        Debug.Log(playerInput.Game.Move.ReadValue<float>());
    }

    private void OnShoot(InputAction.CallbackContext ctx)
    {
        if (Time.time > delayTime)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            delayTime = Time.time + shootDelay;
        }
    }
}
