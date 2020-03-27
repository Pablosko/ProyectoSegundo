using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AND : Node
{
    public bool active;
    public int powerToActivate;
    void Start()
    {
        if (nextPoint != null)
            SpawnLine(nextPoint);
        UpdateHud();
    }

    void Update()
    {
        
    }
    public override void ComponentAction(Electricity electricty)
    {
        base.ComponentAction(electricty);
        if (!active && electricty.power >= powerToActivate)
        {
            active = true;
            Destroy(electricty.gameObject);
        }
        if (!active)
        {
            Destroy(electricty.gameObject);
        }
        if (active)
        {
            //pasa la corriente
        }
    }
}
