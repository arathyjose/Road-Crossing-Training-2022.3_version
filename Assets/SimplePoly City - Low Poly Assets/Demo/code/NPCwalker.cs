using UnityEngine;

public class NPCwalker : MonoBehaviour
{
    public float speed = 1.5f;
    public Transform[] waypoints;
    int index = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            waypoints[index].position,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, waypoints[index].position) < 0.2f)
        {
            index = (index + 1) % waypoints.Length;
        }
    }
}
