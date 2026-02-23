using UnityEngine;

public class MenuFadeIn : MonoBehaviour
{
    public float fadeSpeed = 2f;
    CanvasGroup canvas;

    void Start()
    {
        canvas = GetComponent<CanvasGroup>();
        canvas.alpha = 0;
    }

    void Update()
    {
        if (canvas.alpha < 1)
            canvas.alpha += Time.deltaTime * fadeSpeed;
    }
}
