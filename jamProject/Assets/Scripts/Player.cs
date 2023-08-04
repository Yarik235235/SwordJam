using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float thrust = 6f;
    private float rotationSpeed = 180f;
    private float MaxSpeed = 4.5f;
    private Camera mainCam;
    private Rigidbody rb;
    public float offset;
    public GameObject DottedLine;


    private void Start()
    {
        mainCam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        ControlRocket();
    }

    private void ControlRocket()
    {
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.right * thrust);
            InvokeRepeating("SpawnDottedLine", 2f,0);
        }
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -MaxSpeed, MaxSpeed), Mathf.Clamp(rb.velocity.y, -MaxSpeed, MaxSpeed));
    }

    

    public void ResetRocket()
    {
        transform.position = new Vector2(0f, 0f);
        transform.eulerAngles = new Vector3(0, 180f, 0);
        rb.velocity = new Vector3(0f, 0f, 0f);
        rb.angularVelocity = new Vector3(0f, 0f, 0f);
    }

    public void SpawnDottedLine()
    {
        Instantiate(DottedLine, transform.position, transform.rotation);
    }
}
