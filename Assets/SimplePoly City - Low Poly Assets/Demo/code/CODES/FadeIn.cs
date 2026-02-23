using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public float speed = 2f;
    CanvasGroup cg;

    void Start()
    {
        cg = GetComponent<CanvasGroup>();
        cg.alpha = 0;
    }

    void Update()
    {
        if (cg.alpha < 1)
            cg.alpha += Time.deltaTime * speed;
    }
}
