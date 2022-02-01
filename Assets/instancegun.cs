using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instancegun : MonoBehaviour
{
    public Transform objectpoint;
    public Transform headpoint;

    public Animator anim;

    public Transform Barrel;

    public GameObject Bullet;
    public GameObject RealBullet;
    public GameObject Gun;

    public bool fired = false;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Gun, objectpoint.position, objectpoint.rotation);
        anim.SetBool("Gun", true);
    }

    // Update is called once per frame
    void Update()
    {
        Barrel = GameObject.FindGameObjectWithTag("Barrel").transform;
       


        if (fired == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                shoot();
                fired = true;
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            
            fired = false;
        }
    }
    void shoot()
    {
        Instantiate(Bullet, Barrel.position, Barrel.rotation);
        Instantiate(RealBullet, headpoint.position, headpoint.rotation);
    }
}
