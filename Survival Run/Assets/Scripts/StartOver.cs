using UnityEngine;

public class StartOver : MonoBehaviour
{
    [SerializeField]
    private Transform startOverPos;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        other.transform.position = startOverPos.position;
    }
}