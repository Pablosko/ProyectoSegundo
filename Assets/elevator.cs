using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : InteractuableObject
{
    public float speed;
    public bool move;
    public Transform startPoint;
    public Transform endpoint;

    Vector3 currentPoistion;
    Vector3 nextPosition;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            if (currentPoistion == null)
            {
                nextPosition = endpoint.localPosition;
            }

            Vector3 dir = nextPosition - transform.localPosition;
            transform.Translate(dir.normalized * speed);
        }
    }
    public override void ObjectInteraction()
    {
        move = true;
        base.ObjectInteraction();
    }
}
