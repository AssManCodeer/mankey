using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
    
    public GameObject Player;
    public ParticleSystem DUST;
    public Animator animator;
    public Rigidbody rb;
    public AudioSource Gorrila;
    public bool gun = false;

    bool lol = false;
    // Start is called before the first frame update
    void Start()
    {
        lol = Player.gameObject.GetComponent<Movement>().isGrounded;
        Gorrila.Play();
    }

    // Update is called once per frame
    void Update()
    {
        lol = Player.gameObject.GetComponent<Movement>().isGrounded;


        normal();
      

    }
    void normal()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {

            animator.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Run", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            animator.SetBool("WalkBack", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("WalkBack", false);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("attack");
        }
        if (Input.GetButtonDown("Jump") && lol == true && gun == false)
        {
            DUST.Play();
            animator.SetTrigger("Jump");
        }
    }
   
}
