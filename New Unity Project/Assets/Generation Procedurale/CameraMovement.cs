using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Rigidbody rb;

    private float pitch = 0.0F;
    private float yaw = 0.0F;

    private float camSpeed = 10F;

    private Vector3 movement = Vector2.zero;

    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {


        //ROTATION
        Cursor.lockState = CursorLockMode.Locked;

        pitch -= Input.GetAxis("Mouse Y") * camSpeed;
        yaw += Input.GetAxis("Mouse X") * camSpeed;

        rb.transform.localEulerAngles = new Vector3(pitch, yaw, 0.0F);

        ////MOVEMENT
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        controller.Move(move /** camSpeed * Time.deltaTime*/);


    }




}
