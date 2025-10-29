using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
private Camera Cam;
public float TargetZoom = 3; //The value of Zoom I want by manipulating the Camera Size
private float ScrollData; //Float collected upon Mouse Scrolling
public float ZoomSpeed = 3; //Speed of zooming process in or out
void Start()
{
Cam = GetComponent<Camera>();
TargetZoom = Cam.orthographicSize; 
}

   
    void Update()
    {
        ScrollData= Input.GetAxis("Mouse ScrollWheel");
TargetZoom = TargetZoom - ScrollData;
TargetZoom = Mathf.Clamp(TargetZoom, 3, 6);
Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, TargetZoom, Time.deltaTime * ZoomSpeed);
    }
}
