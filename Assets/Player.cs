using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick fixedJoystick;
    public float diff = 1;
    public GameObject handle;
    public GameObject player;

    void Update()
    {
        

        if (handle.transform.position.x > 0.5f)
        {
            Quaternion newRotation = Quaternion.Euler(0, 0, 0);
            player.transform.rotation = newRotation;
            Vector3 newPos = new Vector3(fixedJoystick.Horizontal, 0);
            transform.position += newPos * diff * Time.deltaTime;
        }

        if (handle.transform.position.x <  - 0.5f)
        {
            Quaternion newRotation = Quaternion.Euler(0, 180, 0);
            player.transform.rotation = newRotation;
            Vector3 newPos = new Vector3(fixedJoystick.Horizontal, 0);
            transform.position += newPos * diff * Time.deltaTime;
        }
    }
}
