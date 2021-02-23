using UnityEngine;

public class StartOver : MonoBehaviour
{
    [SerializeField]
    private Transform startOverPos;

    [SerializeField]
    private float decrease = 5f, speedIncrease = 0.05f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        Debug.Log("Speed: " + other.GetComponent<Movement>().speed);
        var movement = other.GetComponent<Movement>();
        movement.speedIncrease += speedIncrease;
        movement.speed -= decrease;
        other.transform.position = startOverPos.position;
    }
}