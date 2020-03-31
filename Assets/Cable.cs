using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : InteractuableObject
{
    public GameObject paredQueNoDejaPasar;
    void Start()
    {
        
    }

    void Update()
    {
        //parche provisional (chapuza)
        if (!interactuable)
            paredQueNoDejaPasar.SetActive(false);
    }
    public override void ObjectInteraction()
    {
        print("te esta electrocutando");
        paredQueNoDejaPasar.SetActive(true);
        base.ObjectInteraction();
    }
}
