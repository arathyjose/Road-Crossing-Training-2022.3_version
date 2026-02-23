using UnityEngine;
using TMPro;

public class PlayerInstruction : MonoBehaviour
{
    public TextMeshProUGUI messageText;

    void Start()
    {
        ShowMessage("LOOK LEFT AND RIGHT");
    }

    public void ShowMessage(string msg)
    {
        messageText.text = msg;
    }

    public void ShowStop()
    {
        ShowMessage("WAIT! CAR COMING");
    }

    public void ShowGo()
    {
        ShowMessage("SAFE TO CROSS");
    }
}
