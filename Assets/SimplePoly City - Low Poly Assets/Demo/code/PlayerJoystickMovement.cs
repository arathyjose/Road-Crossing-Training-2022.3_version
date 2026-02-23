using UnityEngine;

public class PlayerJoystickMovement : MonoBehaviour
{
    public FixedJoystick joystick;
    public float speed = 2f;

    void Update()
    {
        Vector3 direction = new Vector3(joystick.Horizontal, 0, -joystick.Vertical);

        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
