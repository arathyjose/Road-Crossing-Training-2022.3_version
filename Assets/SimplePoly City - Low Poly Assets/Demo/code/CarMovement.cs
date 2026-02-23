using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public Transform stopPoint;
    public TrafficLightController trafficLight;

    public float speed = 4f;
    public float turnSpeed = 5f;
    public float stopDistance = 1.5f;

    private int currentIndex = 0;
    private bool isStopped = false;

    void Update()
    {
        if (waypoints.Length == 0)
            return;

        // Check stop condition
        if (stopPoint != null && trafficLight != null)
        {
            float distanceToStop = Vector3.Distance(transform.position, stopPoint.position);

            if (distanceToStop < stopDistance && trafficLight.IsRed())
            {
                isStopped = true;
            }
            else
            {
                isStopped = false;
            }
        }

        if (isStopped)
            return;

        Transform target = waypoints[currentIndex];
        Vector3 direction = (target.position - transform.position).normalized;

        // Ignore vertical difference
        Vector3 flatDirection = new Vector3(direction.x, 0, direction.z);

        // Only rotate if direction is valid
        if (flatDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(flatDirection);

            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                turnSpeed * 100f * Time.deltaTime
            );
        }



        transform.position += transform.forward * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, target.position) < 1.2f)
        {
            currentIndex++;

            if (currentIndex >= waypoints.Length)
                currentIndex = 0;
        }
        
        {
            Debug.Log(transform.position.y);
        }


    }
}
