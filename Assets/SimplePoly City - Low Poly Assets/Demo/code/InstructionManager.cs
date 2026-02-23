using UnityEngine;
using TMPro;
using System.Collections;

public class InstructionManager : MonoBehaviour
{
    public GameObject popup;
    public TextMeshProUGUI messageText;

    public void ShowMessage(string message, float duration)
    {
        StopAllCoroutines();
        popup.SetActive(true);
        messageText.text = message;
        StartCoroutine(HideAfterTime(duration));
    }

    IEnumerator HideAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        popup.SetActive(false);
    }
}
