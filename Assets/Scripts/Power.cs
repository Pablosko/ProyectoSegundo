using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public Transform firstNode;
    public GameObject electricity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activate()
    {
        GameObject ele = Instantiate(electricity, transform.parent);
        ele.GetComponent<Electricity>().UpdateTarget(firstNode.gameObject.GetComponent<Node>().nextPoint);
        ele.transform.localPosition = firstNode.gameObject.transform.localPosition;
    }
}
