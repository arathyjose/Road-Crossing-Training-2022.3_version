using UnityEngine;

public class CarDetector : MonoBehaviour
{
    public PlayerInstruction playerUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            playerUI.ShowStop();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            playerUI.ShowGo();
        }
    }
}
