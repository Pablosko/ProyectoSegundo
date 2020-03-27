using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : Node
{
    public int startingPower;
    void Start()
    {
        if (nextPoint != null)
            SpawnLine(nextPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void ComponentAction(Electricity electricty)
    {
        base.ComponentAction(electricty);
        electricty.power = startingPower;
    }
}
