using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController myass;


    public bool isGrounded;
    public float sprint = 20f;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float fallspeed = 3f;

    public Transform groundCheck;
    public float grounddistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, grounddistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -20f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        myass.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        myass.Move(velocity * Time.deltaTime);
            
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

       if( Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = sprint;
        }
       else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 12f;
        }

    }
}
