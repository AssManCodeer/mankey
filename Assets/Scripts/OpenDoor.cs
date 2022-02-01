using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator DoorR;
    public Animator DoorL;
    public bool isclosed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && isclosed == false)
        {
            DoorL.SetTrigger("Open");
            DoorR.SetTrigger("Open");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isclosed = true;
            DoorL.SetTrigger("Close");
            DoorR.SetTrigger("Close");
        }
    }
}
