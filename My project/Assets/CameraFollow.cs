using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  
public Transform Target;
public float Cameraspeed;
public float minX, maxX;
public float miny, maxY;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(Target!=null)
{
Vector2 newCamPosition = Vector2.Lerp (transform.position, Target.position, Time.deltaTime * Cameraspeed);
float ClampX = Mathf.Clamp (newCamPosition.x, minX, maxX);
float ClampY = Mathf.Clamp (newCamPosition.y, miny, maxY);
transform.position = new Vector3(ClampX, ClampY, -10f);
    }
    }
}
