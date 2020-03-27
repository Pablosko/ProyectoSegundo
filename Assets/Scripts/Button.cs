using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : Node
{
    [Header("Button")]
    public Transform ButtonNextPoint;
    public int newPower;
    // Start is called before the first frame update
    void Start()
    {
        if (nextPoint != null)
            SpawnLine(nextPoint);
        SpawnLine(ButtonNextPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void ComponentAction(Electricity electricty)
    {
        GameObject ele = Instantiate(electricty.gameObject, transform.parent);
        ele.GetComponent<Electricity>().power = newPower;
        ele.GetComponent<Electricity>().UpdateTarget(ButtonNextPoint);
        base.ComponentAction(electricty);
    }
}
