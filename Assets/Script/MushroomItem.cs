using UnityEngine;

public class MushroomItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            MushroomCollector collector = other.GetComponent<MushroomCollector>();
            if (collector != null)
            {
                collector.AddMushroom();
            }

            Destroy(gameObject); // キノコを消す
        }
    }
}
