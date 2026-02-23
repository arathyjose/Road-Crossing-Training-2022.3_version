using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    public float redTime = 20f;
    public float greenTime = 15f;
    public float yellowTime = 2f;


    public bool IsRed()
    {
        return redLight.activeSelf;
    }

    void Start()
    {
        StartCoroutine(TrafficCycle());
    }

    System.Collections.IEnumerator TrafficCycle()
    {
        while (true)
        {
            // RED
            SetLight(true, false, false);
            yield return new WaitForSeconds(redTime);

            // GREEN
            SetLight(false, false, true);
            yield return new WaitForSeconds(greenTime);

            // YELLOW
            SetLight(false, true, false);
            yield return new WaitForSeconds(yellowTime);
        }
    }

    void SetLight(bool red, bool yellow, bool green)
    {
        redLight.SetActive(red);
        yellowLight.SetActive(yellow);
        greenLight.SetActive(green);
    }
}