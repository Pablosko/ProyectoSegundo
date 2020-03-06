using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public PlayerController player;
    public CameraController camController;
    public GameObject line;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        Debug.Log(line);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            camController.SwitchView((State)(camController.state + 1));
        }
    }
}
