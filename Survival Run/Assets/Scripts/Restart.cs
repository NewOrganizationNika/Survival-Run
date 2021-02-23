using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    [SerializeField]
    private int index;

    public void RestartGame()
    {
        SceneManager.LoadScene(index);
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