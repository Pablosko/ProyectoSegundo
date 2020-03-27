using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPuzzle : InteractuableObject
{
    public GameObject puzzle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void ObjectInteraction()
    {

        print("empiezaElPuzzle");
        GameController.instance.ChangeCanvas(true);
        GameController.instance.CurrentPuzzle = gameObject;
        Instantiate(puzzle, GameController.instance.puzzleCanvasO.GetComponent<PuzzleController>().Canvas.transform);

    }
}
