using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Node
{
    [Header("Button")]
    public Transform ButtonNextPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void ComponentAction(Electricity electricty)
    {
        GameObject ele = Instantiate(electricty.gameObject, transform.parent);
        ele.GetComponent<Electricity>().UpdateTarget(ButtonNextPoint);
        base.ComponentAction(electricty);
    }
}
