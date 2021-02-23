using UnityEngine;

public class Cheat : MonoBehaviour
{
    [SerializeField]
    private bool up;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        if (up)
        {
            var transform1 = other.transform;
            var pos = transform1.position;
            pos.y += 1;
            transform1.position = pos;
        }
        else
        {
            var transform1 = other.transform;
            var pos = transform1.position;
            pos.y -= 1;
            transform1.position = pos;
        }
    }
}