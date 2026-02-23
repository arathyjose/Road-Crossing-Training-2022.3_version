using UnityEngine;
using UnityEngine.EventSystems;

public class Button3DEffect : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localPosition = startPos + new Vector3(0, -5, 0);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localPosition = startPos;
    }
}
