
using UnityEngine;

public class TeleportOnTouchAndKey : MonoBehaviour
{
    public Transform teleportTarget;     // テレポート先（マット上）
    public GameObject xrRig;             // プレイヤー（XR Origin）
    private bool isTouching = false;     // プレイヤーが触れているかどうか

    void Update()
    {
        if (isTouching && Input.GetKeyDown(KeyCode.G))
        {
            Vector3 target = teleportTarget.position;
            Vector3 current = xrRig.transform.position;

            // 高さは維持、XとZだけ移動
            xrRig.transform.position = new Vector3(target.x, current.y, target.z);
            Debug.Log("Teleported to mat!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTouching = true;
            Debug.Log("Touching the button");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTouching = false;
            Debug.Log("Left the button");
        }
    }
}