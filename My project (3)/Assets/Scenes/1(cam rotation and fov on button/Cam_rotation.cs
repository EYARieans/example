using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_rotation : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    public float sensX;
    public float sensY;
    float xRotation;
    float yRotation;
    float m_FieldOfView;

    //Cam zoom in zoom out 
    /* public Transform cameraTarget1;
     public Transform cameraTarget2;
     public float sSpeed = 10.0f;

     private int currenttarget;
     private Transform cameraTarget;*/
    void Start()
    {
       playerCamera.fieldOfView = 60.0f;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxisRaw("Mouse X") * sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;

            yRotation += mouseX;
            xRotation -= mouseY;
            // yRotation = Mathf.Clamp(yRotation,-180f, 180f);
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            // yRotation = Mathf.Clamp(-90f, xRotation, 90f);
            //rotate cam and orientation
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        }
       // Camera.main.fieldOfView = m_FieldOfView;

    }
    
   public void Zoomout()
    {
        playerCamera.fieldOfView = 100.0f;
    }
    public void Zoomin()
    {
        playerCamera.fieldOfView = 60.0f;
    }
}
