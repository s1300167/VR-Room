using UnityEngine;

public class TeleportToAnchorTarget : MonoBehaviour
{
    public Transform teleportTarget;  // テレポート先の Transform
    public GameObject xrRig;          // XR Origin（プレイヤー）

    public void Teleport()
    {
        if (teleportTarget != null && xrRig != null)
        {
            // 高さを維持してテレポート
            Vector3 targetPosition = teleportTarget.position;
            float currentY = xrRig.transform.position.y;
            xrRig.transform.position = new Vector3(targetPosition.x, currentY, targetPosition.z);

            // 回転を合わせたいならこれも使う（任意）
            // xrRig.transform.rotation = teleportTarget.rotation;

            Debug.Log("テレポートしました！");
        }
    }
}