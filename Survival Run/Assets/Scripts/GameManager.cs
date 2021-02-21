using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI gamePlayText;

    private float tmpTime;

    private void Update()
    {
        tmpTime += Time.deltaTime;
        gamePlayText.text = tmpTime.ToString("0.00");
    }

    [SerializeField]
    private TextMeshProUGUI gameOverText;

    private float timeCounter;

    public void SetBlueChosenTime()
    {
        timeCounter = tmpTime;
        gameOverText.text =
            "You fought valiantly but even your soul couldn't take the pressure of this goddamned world. " +
            "Remember there is nothing shameful about giving up. " +
            "The only shameful thing is giving up without even trying. " +
            "And you know best how much you tried: " +
            timeCounter.ToString("0.00");
    }
}