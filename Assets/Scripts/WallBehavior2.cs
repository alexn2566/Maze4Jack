using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior2 : MonoBehaviour
{
    public float rotateWallSpeed = 3f;   
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.down * rotateWallSpeed);
    }
}
