using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void Interaction();
public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    CameraController cam;
    public float Speed;
    public float gravity = -9.81f;
    public Interaction interaction;
    public CharacterController controller;
    Vector3 velocity;
    BoxCollider playerCollider;
    float colliderSize;
    //
    public float sneekProportion;

    void Start()
    {
        transform.localPosition = GameController.instance.spawnPoint.localPosition;
        colliderSize = controller.height;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.E))
        {
            interaction();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            controller.height = colliderSize / sneekProportion;
            GameController.instance.camController.camera.transform.Translate(Vector3.down * 0.4f) ; 
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            controller.height = colliderSize;
            GameController.instance.camController.transform.position = transform.position + Vector3.up * 0.4f;
        }
    }

    public void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * Speed * Time.deltaTime);

        controller.Move(Vector3.up * gravity * Time.deltaTime);
    }
}
