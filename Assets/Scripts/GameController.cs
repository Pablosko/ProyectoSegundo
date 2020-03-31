using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public PlayerController player;
    public CameraController camController;
    public GameObject line;
    public GameObject puzzleCanvasO;
    public GameObject MainCanvasO;
    public GameObject CurrentPuzzle;
    public Transform spawnPoint;
    public Text messageTxt;
    public PuzzleController puzzleController;

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
    public void ChangeCanvas(bool puzzle)
    {
        GameController.instance.puzzleCanvasO.SetActive(puzzle);
        GameController.instance.MainCanvasO.SetActive(!puzzle);
    }
}
