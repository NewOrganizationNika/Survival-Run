using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField]
    private int index;

    public void RestartGame()
    {
        SceneManager.LoadScene(index);
    }
}