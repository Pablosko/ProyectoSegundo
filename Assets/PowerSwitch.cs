using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitch : InteractuableObject
{
    public bool active;
    public List<InteractuableObject> objectsToActivate = new List<InteractuableObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void ObjectInteraction()
    {
        active = !active;
        foreach (InteractuableObject ob in objectsToActivate)
        {
            ob.interactuable = active;
        }
        base.ObjectInteraction();
    }
}
