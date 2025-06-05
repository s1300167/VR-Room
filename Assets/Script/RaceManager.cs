using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RaceManager : MonoBehaviour
{
    public Transform playerRig;       // XR Origin
    public Transform startPoint;      // スタート地点
    public RaceTimer raceTimer;       // タイマースクリプト
    public GameObject startButtonUI;  // スタートボタンのUI

    public void StartRace()
    {
        playerRig.position = startPoint.position;
        playerRig.rotation = startPoint.rotation;

        raceTimer.StartTimer();

        startButtonUI.SetActive(false);
    }
}
