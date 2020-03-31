using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractuableObject
{
    public GameObject part1;
    public GameObject part2;
    public float howMuchMove;
    // Start is called before the first frame update
    IEnumerator OpenDoor()
    {
        while (part2.transform.localPosition.z < howMuchMove)
        {
            part1.transform.Translate(Vector3.back * 1 * 0.05f);
            part2.transform.Translate(Vector3.back * -1 * 0.05f);
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
