using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public CanvasGroup fadePanel;

    public void StartGame()
    {
        StartCoroutine(LoadScene());
    }

    System.Collections.IEnumerator LoadScene()
    {
        fadePanel.gameObject.SetActive(true);

        while (fadePanel.alpha < 1)
        {
            fadePanel.alpha += Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene("RoadCrossing");
    }
}
