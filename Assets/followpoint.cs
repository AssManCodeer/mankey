using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpoint : MonoBehaviour
{
    public Transform objectpoint;

    // Start is called before the first frame update
    void Start()
    {
        objectpoint = GameObject.FindGameObjectWithTag("Objectpoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectpoint.position;
        transform.rotation = objectpoint.rotation;
    }
}
