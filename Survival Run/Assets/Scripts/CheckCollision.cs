using UnityEngine;
using UnityEngine.Events;

public class CheckCollision : MonoBehaviour
{
    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private UnityEvent onGameOver;

    private void Update()
    {
        if (Physics2D.OverlapPoint(transform.position, ~layerMask)) return;
        print("Lost");
        onGameOver?.Invoke();
    }
}