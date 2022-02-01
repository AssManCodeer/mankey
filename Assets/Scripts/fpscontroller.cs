using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpscontroller : MonoBehaviour
{
    public float mouseSen = 100f;

    public Transform player;

    float xRotatos = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSen * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSen * Time.deltaTime;

        xRotatos -= mouseY;
        xRotatos = Mathf.Clamp(xRotatos, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotatos, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
