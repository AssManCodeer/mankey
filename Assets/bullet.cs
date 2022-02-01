using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody rb;

    public LayerMask lays;

    public float shootForce;
    public float range;


    public Camera cam;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * shootForce);
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range, lays))
        {

            hit.transform.gameObject.GetComponent<Target>().damaged();
            Destroy(this.gameObject);
            Debug.Log("sssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
    

}
