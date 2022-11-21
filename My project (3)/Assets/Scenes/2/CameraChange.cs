using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public Camera cam;
    float m_FieldOfView;


     float minFov= 15f;
     float maxFov = 90f;
     float sens=20f;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
          float  fov= Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") *sens ;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
        //Debug.Log(gamobj.transform.position);
    }

    public void Pos_change()
    {
        cam.transform.position = pos2.transform.position;
    }
    public void Pos_change_back()
    {
        cam.transform.position = pos1.transform.position;
    }
}
