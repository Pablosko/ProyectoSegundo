using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Transform nextPoint;
    GameObject lineGameObject;
    Transform lineParent;
    void Start()
    {
        SpawnLine();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("entra");
        if (other.GetComponent<Electricity>() != null)
        {
            ComponentAction(other.GetComponent<Electricity>());
        }
    }
    public void SpawnLine()
    {
        lineParent = transform.parent.GetChild(0);
        lineGameObject = GameController.instance.line;
        GameObject line = Instantiate(lineGameObject, lineParent);
        line.transform.localPosition = transform.localPosition;
        Vector3 dir = nextPoint.localPosition - transform.localPosition;

        float angle = Vector2.SignedAngle( Vector3.right,dir);

        line.GetComponent<RectTransform>().sizeDelta = new Vector2(dir.magnitude - GetComponent<RectTransform>().sizeDelta.x/2, 100);

        line.GetComponent<RectTransform>().localRotation = Quaternion.Euler(0, 0, angle);
    }
    public virtual void ComponentAction(Electricity electricty)
    {
        electricty.UpdateTarget(nextPoint);
    }
}
