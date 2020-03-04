using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricity : MonoBehaviour
{
    public Vector3 target;
    public Vector3 direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = target - transform.localPosition;
        transform.Translate(direction.normalized * speed);
    }

    public void UpdateTarget(Transform trans)
    {
        target = trans.localPosition;
    }
}
