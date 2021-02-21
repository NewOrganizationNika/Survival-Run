using UnityEngine;

public class FinishBlocks : MonoBehaviour
{
    [SerializeField]
    private bool isRed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            other.GetComponent<ChangeColor>().SetActive(isRed);
    }
}