using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class StartPositionSetter : MonoBehaviour
{
    public GameObject xrRig;       // XR Rig (Action Based)
    public Transform startPoint;   // スタート地点
    public RaceTimer raceTimer;    // タイマースクリプト

    void Start()
    {
        // スタート地点にXR Rigをセット
        xrRig.transform.position = startPoint.position;
        xrRig.transform.rotation = startPoint.rotation;

        // タイマー開始
        if (raceTimer != null)
        {
            raceTimer.StartTimer();
        }
    }
}
