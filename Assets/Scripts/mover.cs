using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public Rigidbody rb;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = rb.transform.position - transform.position;
        rb.AddForceAtPosition(direction.normalized, transform.position);
    }
}
