using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float damage = 10f;
    public GameObject Enemy;
    
    
    private float currenthealth;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage (float amount)
    {
        Enemy.gameObject.GetComponent<maxHealth>().TakeDamage(damage);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            Enemy.gameObject.GetComponent<maxHealth>().TakeDamage(damage);
        }
        
    }
    public void damaged()
    {
        Enemy.gameObject.GetComponent<maxHealth>().TakeDamage(damage);
    }
}
