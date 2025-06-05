using UnityEngine;
using TMPro;

public class RaceTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float elapsedTime = 0f;
    private bool isRunning = false;

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            timerText.text = elapsedTime.ToString("F2") + " s";
        }
    }

    public void StartTimer()
    {
        elapsedTime = 0;
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}
