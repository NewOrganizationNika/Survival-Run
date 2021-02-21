using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField, Min(0.0001f)]
    private float speed = 1f, speedIncrease = 0.1f;

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
        var player = transform;
        player.position += player.right * (speed * Time.deltaTime);
    }

    public void CancelEverything()
    {
        StopAllCoroutines();
        CancelInvoke();
    }
}