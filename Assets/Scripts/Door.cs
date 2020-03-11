using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractuableObject
{
    // Start is called before the first frame update
    IEnumerator OpenDoor()
    {
        while (transform.rotation.y < 90 && transform.rotation.y > -90)
        {
            transform.Rotate(0, 1, 0, Space.Self);
            yield return Time.deltaTime;
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public override void ObjectInteraction()
    {
        StartCoroutine(OpenDoor());

        print("me abro");
    }
}
