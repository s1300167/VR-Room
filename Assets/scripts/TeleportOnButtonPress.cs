using UnityEngine;

public class TeleportOnButtonPress : MonoBehaviour
{
    public Transform teleportTarget;  // マット上の目的地
    public Transform xrRig;          // XR Rig (XR Origin)

    public void TeleportPlayer()
    {
        if (xrRig != null && teleportTarget != null)
        {
            // 現在のY（高さ）を保ちつつ、XとZだけ変更
            Vector3 currentPosition = xrRig.transform.position;
            Vector3 targetPosition = teleportTarget.position;

            xrRig.transform.position = new Vector3(
                targetPosition.x,
                targetPosition.y,  // 地面と衝突しないように高さは保持
                targetPosition.z
            );
        }

      
    }
}