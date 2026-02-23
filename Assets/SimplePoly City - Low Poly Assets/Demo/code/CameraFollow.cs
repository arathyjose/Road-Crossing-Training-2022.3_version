using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        transform.position = target.position + new Vector3(0, 2.5f, -4);
        transform.LookAt(target);
    }
}
