using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realBullet : MonoBehaviour
{
    public Rigidbody rb;

    public LayerMask lays;

    public float shootForce;

  
    // Start is called before the first frame update
    void Start()
    {
        Object.Destroy(gameObject, 20);
         
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * shootForce);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100, lays))
        {
            
            hit.transform.gameObject.GetComponent<Target>().damaged();
            Object.Destroy(gameObject);
            Debug.Log("sssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == lays)
        {
            Debug.Log("shot");
            Object.Destroy(gameObject);
        }
        

    }
}