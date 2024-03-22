using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed of movement
    public RectTransform joystick; // Reference to the joystick's RectTransform
    private Vector2 movementInput;

    void Update()
    {
        // Get the input from the joystick
        movementInput.x = Input.GetAxis("Horizontal");
        movementInput.y = Input.GetAxis("Vertical");

        // Normalize the input vector to prevent faster movement diagonally
        movementInput.Normalize();

        // Move the object
        MoveObject();
    }

    void MoveObject()
    {
        // Calculate the movement vector based on input and speed
        Vector2 movement = movementInput * speed * Time.deltaTime;

        // Translate the object's position
        transform.Translate(movement.x, movement.y, 0f);
    }
}
