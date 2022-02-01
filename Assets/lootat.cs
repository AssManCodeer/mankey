using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootat : MonoBehaviour
{
    public float turnSpeed;

    public LayerMask lays;

    public Rigidbody rb;

    public Camera fpsCam;

    public float range = 100f;

    public GameObject Bullet;

    private bool shot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(GameObject.FindGameObjectWithTag("Player").transform.position - rb.position), turnSpeed * Time.deltaTime);

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, lays))
        {
            if(shot == false)
            {
                Instantiate(Bullet, fpsCam.transform.position, fpsCam.transform.rotation);
                shot = true;
                StartCoroutine(Fade());
            }
            
            Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            
        }
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward * 1000000), Color.blue);

    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(2f);
        shot = false;

    }
    void OnDrawGizmosSelected()
    {
        if (transform.position != null)
        {
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, transform.position);
        }
    }

}
