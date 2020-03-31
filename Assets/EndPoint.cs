using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : Node
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void ComponentAction(Electricity electricty)
    {
        Destroy(electricty.gameObject);
        GameController.instance.ChangeCanvas(false);
        Destroy(GameController.instance.CurrentPuzzle);
        GameController.instance.messageTxt.text = "Puzzle Finished";
        Invoke("off", 1);
        GameController.instance.puzzleController.puzzleStartedBy.ActiveComponents();
    }
    void off()
    {
        GameController.instance.messageTxt.gameObject.SetActive(false);
    }
}
