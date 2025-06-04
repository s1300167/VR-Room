using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportButton : MonoBehaviour
{
    public Vector3 teleportPosition;  // テレポート先の座標をInspectorで指定
    public Quaternion teleportRotation = Quaternion.identity; // テレポート時の回転（任意で指定）
    public Transform playerRig;       // プレイヤーやカメラリグのTransform

    void Start()
    {
        var interactable = gameObject.GetComponent<XRBaseInteractable>();
        if (interactable == null)
        {
            interactable = gameObject.AddComponent<XRBaseInteractable>();
        }

        interactable.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        TeleportPlayer();
    }

    private void OnMouseDown()
    {
        TeleportPlayer();
    }

    private void TeleportPlayer()
    {
        playerRig.position = new Vector3(13, 3, -4);
        playerRig.rotation = teleportRotation;
    }
}
