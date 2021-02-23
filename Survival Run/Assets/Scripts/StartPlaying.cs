using System;
using UnityEngine;
using UnityEngine.UI;

public class StartPlaying : MonoBehaviour
{
    private void Awake()
    {
        StopPlaying();
    }

    public void StopPlaying()
    {
        Time.timeScale = 0f;
    }

    public void StartPlay()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Button();
    }

    private void Button()
    {
        GetComponent<Button>().onClick.Invoke();
    }
}