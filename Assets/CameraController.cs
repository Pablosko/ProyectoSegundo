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
        camera.transform.Rotate(y, 0, 0);
        GameController.instance.player.transform.Rotate(0, x, 0);
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
}
