using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToLogin : MonoBehaviour
{
    public void GoToLogin()
    {
        SceneManager.LoadScene("LoginScene");
    }
}
