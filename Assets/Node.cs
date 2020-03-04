﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Transform nextPoint;
    public GameObject lineGameObject;
    void Start()
    {
        SpawnLine();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("entra");
        if (other.GetComponent<Electricity>() != null)
        {
            other.GetComponent<Electricity>().UpdateTarget(nextPoint);
        }
    }
    public void SpawnLine()
    {
        GameObject line = Instantiate(lineGameObject, transform.parent);
        line.transform.localPosition = transform.localPosition;
        Vector3 dir = nextPoint.localPosition - transform.localPosition;

        float angle = Vector2.SignedAngle( Vector3.right,dir);

        line.GetComponent<RectTransform>().sizeDelta = new Vector2(dir.magnitude - GetComponent<RectTransform>().sizeDelta.x/2, 100);

        line.GetComponent<RectTransform>().localRotation = Quaternion.Euler(0, 0, angle);
    }
}
