using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private GameObject red, blue;

    private void Start()
    {
        SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Red"))
            SetActive(false);
        else if (other.CompareTag("Blue"))
            SetActive(true);
    }

    public void SetActive(bool isRed)
    {
        red.SetActive(isRed);
        blue.SetActive(!isRed);
    }
}