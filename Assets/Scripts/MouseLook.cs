using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Outlets
    public float mouseSensitivity = 100f;
    public Transform playerTransform;

    float rotationX = 0f;
    bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        //prevent mouse from moving while looking around
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        handleMouseMovement();
    }

    //mouse look camera movement 
    void handleMouseMovement()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //camera x rotation is up and down; clamp it so your camera cannot do flips
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.right);

        //rotate playerTransform to look left and right
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
