using UnityEngine;
using UnityEngine.Events;
using Utilities;

public class GameOver : MonoBehaviour
{
    public UnityEvent onGameOver;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        onGameOver?.Invoke();
    }
}