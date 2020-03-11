using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    firstPerson,
    thirdPerson
}

public class CameraController : MonoBehaviour
{
    public Camera camera;
    public State state;
    public float sensibility;
    public Vector3 Offset;
    public float YAxisAngleLock = 90;
    void Start()
    {
        camera = GetComponent<Camera>();
        SwitchView(state);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = sensibility * Input.GetAxis("Mouse X");
        float y = sensibility * -Input.GetAxis("Mouse Y");

        float temp = camera.transform.localRotation.x + y;



        //Quaternion cameraRotation = camera.transform.localRotation;
        //LockCameraMovement(cameraRotation);
        //camera.transform.localRotation = cameraRotation;


        GameController.instance.player.transform.Rotate(0, x, 0);
        camera.transform.Rotate(y, 0, 0);

    }
    public void SwitchView(State newState)
    {
        if (newState > (State)1)
            newState = 0;

        if (newState == State.firstPerson)
        {
            camera.transform.position = GameController.instance.player.transform.position + Vector3.up*0.4f;
        }
        if (newState == State.thirdPerson)
        {
            camera.transform.localPosition = Offset;
        }
        state = newState;
    }
    private Quaternion LockCameraMovement(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        var angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, -YAxisAngleLock, YAxisAngleLock);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }
}
