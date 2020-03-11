using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void Interaction();
public class PlayerController : MonoBehaviour
{
    
    // Start is called before the first frame update
    CameraController cam;
    private Rigidbody rb;
    public float acceleration;
    public float maxSpeed;
    public Interaction interaction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.E))
        {
            interaction();
        }
    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * acceleration);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -acceleration);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -acceleration);
        }
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);


    }
}
