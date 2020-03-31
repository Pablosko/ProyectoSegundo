using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    public GameObject Canvas;
    public StartPuzzle puzzleStartedBy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RefreshPuzzle()
    {
       GameObject go = Instantiate(GameController.instance.CurrentPuzzle.GetComponent<StartPuzzle>().puzzle,Canvas.transform);
       Destroy(GameController.instance.CurrentPuzzle);
       GameController.instance.CurrentPuzzle = go;
    }
}
