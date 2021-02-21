using System;
using UnityEngine;
using Random = UnityEngine.Random;

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
        if (other.CompareTag("Blue"))
        {
            Debug.Log("Blue");

            SetActive(true);
        }
        else if (other.CompareTag("Red"))
        {
            Debug.Log("Red");

            SetActive(false);
        }
        else if (other.CompareTag("Finish"))
        {
            Debug.Log("Finish");

            return; //Win logic
        }
        else if (other.CompareTag("Respawn"))
        {
            Debug.Log("Respawn");

            return;
        }
        else if (other.CompareTag("Death"))
        {
            Debug.Log("death");
            Destroy(gameObject); //Lose Logic
        }
    }

    private void SetActive(bool isRed)
    {
        red.SetActive(isRed);
        blue.SetActive(!isRed);
    }
}