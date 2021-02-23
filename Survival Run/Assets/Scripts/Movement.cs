using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField, Min(0.0001f)]
    public float speed = 1f, speedIncrease = 0.1f;

    [SerializeField, Min(0.1f)]
    private float time = 1f, rate = 0.5f;

    private void Start()
    {
        InvokeRepeating(nameof(IncreaseSpeed), time, rate);
    }

    private void IncreaseSpeed()
    {
        speed += speedIncrease;
    }

    private void Update()
    {
        // var player = transform;
        // player.position += player.right * (speed * Time.deltaTime);
        Move(speed);
    }

    [Range(0, .3f)]
    [SerializeField]
    private float m_MovementSmoothing = .05f; // How much to smooth out the movement

    private Rigidbody2D rb2D;
    private Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Move(float move)
    {
        // Move the character by finding the target velocity
        Vector3 targetVelocity = new Vector2(move, rb2D.velocity.y);
        // And then smoothing it out and applying it to the character
        rb2D.velocity =
            Vector3.SmoothDamp(rb2D.velocity, targetVelocity, ref velocity, m_MovementSmoothing);
    }

    public void CancelEverything()
    {
        StopAllCoroutines();
        CancelInvoke();
    }
}