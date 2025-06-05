using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("MainCamera"))
        {
            Debug.Log("ゴール！！");

            FindObjectOfType<RaceTimer>().StopTimer();
        }
    }
}