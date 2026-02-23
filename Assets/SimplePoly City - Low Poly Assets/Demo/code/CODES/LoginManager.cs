using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TextMeshProUGUI errorText;

    private string correctUsername = "admin";
    private string correctPassword = "1234";

    public void Login()
    {
        if (usernameInput.text == correctUsername &&
            passwordInput.text == correctPassword)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            errorText.gameObject.SetActive(true);
            errorText.text = "Invalid username or password";
        }
    }
}
