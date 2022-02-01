using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxHealth : MonoBehaviour
{
    
    
    public ParticleSystem Blood;
    public float health = 50f;
    private float currenthealth;
    // Start is called before the first frame update
    void Start()
    {
       
        currenthealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float amount)
    {
        this.GetComponentInChildren<ragdollcontroller>().lol = false;
        this.GetComponentInChildren<Animator>().enabled = false;

        Blood.Play();

        currenthealth -= amount;

        if (currenthealth <= 0)
        {
            die();
        }
    }
    void die()
    {
        Debug.Log("fuck you");
        this.gameObject.SetActive(false);
    }
}
