using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Red") || other.CompareTag("Blue"))
            Destroy(other.gameObject);
    }
}