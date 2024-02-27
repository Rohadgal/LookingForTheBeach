using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 2.0f;
    public float minXRotation = -80.0f;
    public float maxXRotation = 80.0f;

    static public float rotationY = 0;

    void Update() {
        float mouseX = -Input.GetAxis("Mouse X");
        
        //transform.Rotate(Vector3.up * mouseX * rotationSpeed);

       
        rotationY -= mouseX * rotationSpeed;
        rotationY = Mathf.Clamp(rotationY, minXRotation, maxXRotation);

        transform.localRotation = Quaternion.Euler(0, rotationY, 0);
    }
}
