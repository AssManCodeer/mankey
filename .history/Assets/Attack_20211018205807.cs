using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject explodedBubble; 
    public LayerMask layermask;
    public LayerMask Pickupmask;
    public float damage = 10f;
    public float range = 10f;
    public Camera fpsCam;
    public GameObject myHands;
    public GameObject[] ObjectIwantToPickUp;
    bool hasItem = false;
    public float strength = 1f;
    public Animator attack;
    public bool gun = false;
    public float closeDistance = 5;
    public GameObject objectos;
    public GameObject Objecttopickup;
    public Animator arms;


    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjectIwantToPickUp = GameObject.FindGameObjectsWithTag("object");
        float distancetoclosetsPickup = Mathf.Infinity;
        GameObject Closestobject = null;
        foreach (GameObject pickupss in ObjectIwantToPickUp)
        {
            float distancetoPickup = (pickupss.transform.position - this.transform.position).sqrMagnitude;
            if (distancetoPickup < distancetoclosetsPickup)
            {
                distancetoclosetsPickup = distancetoPickup;
                Closestobject = pickupss;
                objectos = pickupss.gameObject;
            }
                
        }
            
if(hasItem == true){
    objectos.transform.position = myHands.transform.position;
            objectos.transform.rotation = myHands.transform.rotation;
}
        if (Input.GetKeyDown(KeyCode.E) && hasItem == false)
        {
            pickup();
        }
        if (Input.GetKeyDown("q") && hasItem == true) // if you have an item and get the key to remove the object, again can be any key
        {

            Drop();
        }

        if (Input.GetButtonDown("Fire1") && gun == false)
        {
            attack.SetTrigger("attack");
            Shoot();
        }
    }
    
    void pickup()
    {
        
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, Pickupmask))
        {
            arms.SetBool("Gun", true);

            Objecttopickup = hit.transform.gameObject;

            Objecttopickup.transform.localEulerAngles = new Vector3(0, 0, 0);

            Objecttopickup.GetComponent<BoxCollider>().enabled = false;
            hasItem = true;
            Objecttopickup.GetComponent<Rigidbody>().isKinematic = true;
    
            Objecttopickup.GetComponent<gun>().enabled = true;
        }
    }
    void Drop()
    {
        gun = false;
        hasItem = false;
        objectos.transform.localEulerAngles = new Vector3(0, 0, 0);

        objectos.GetComponent<BoxCollider>().enabled = true;
        objectos.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        objectos.GetComponent<Rigidbody>().isKinematic = false;

        objectos.GetComponent<gun>().enabled = true;

        arms.SetBool("Gun", false);
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, layermask))
        {
            
            GameObject explosion = Instantiate(explodedBubble, hit.point, Quaternion.identity);
            Debug.Log("hit");
            Destroy(explosion, 1f);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
        
    }
    private void FixedUpdate()
    {
        //if(hasItem == true)
        {
            //objectos.transform.position = myHands.transform.position;
            //objectos.transform.rotation = myHands.transform.rotation;
        }
    }

}
