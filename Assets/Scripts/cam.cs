using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
 {
    public LayerMask layer;
   public Camera Cam;

    void Start()
    {
        // Only render objects in the first layer (Default layer)
        Cam.cullingMask = layer;
       
    }
}