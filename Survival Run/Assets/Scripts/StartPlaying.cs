using UnityEngine;

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
}