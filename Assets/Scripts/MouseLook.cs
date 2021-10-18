using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float xSpeed = 2.0f;
    public float ySpeed = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        yaw += xSpeed * Input.GetAxis("Mouse X");
        pitch += ySpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);
    }
}
