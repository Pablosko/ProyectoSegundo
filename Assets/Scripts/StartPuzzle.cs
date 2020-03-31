using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPuzzle : InteractuableObject
{
    public GameObject puzzle;
    public List<InteractuableObject> objectsToActivate = new List<InteractuableObject>();
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
        GameController.instance.CurrentPuzzle = puzzle;
        Instantiate(puzzle, GameController.instance.puzzleCanvasO.GetComponent<PuzzleController>().Canvas.transform);
        GameController.instance.puzzleCanvasO.GetComponent<PuzzleController>().puzzleStartedBy = this;
    }
    public void ActiveComponents()
    {
        foreach (InteractuableObject ob in objectsToActivate)
        {
            ob.interactuable = true;
        }
    }

}
