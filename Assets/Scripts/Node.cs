using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public Transform nextPoint;
    GameObject lineGameObject;
    Transform lineParent;
    public bool endPoint;
    public int powerVariaton;
    public int requiredPower;

    public Text powerVariationtxt;
    public Text requiredPowertxt;

    void Start()
    {
        if(nextPoint != null)
        SpawnLine(nextPoint);

        UpdateHud();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("entra");
        if (other.GetComponent<Electricity>() != null)
        {
            ComponentAction(other.GetComponent<Electricity>());
        }
    }
    public void SpawnLine(Transform nextPoint)
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
        if (electricty.power >= requiredPower)
        {
            electricty.AddPower(-powerVariaton);
            if (endPoint)
            {
                Destroy(electricty.gameObject);
                GameController.instance.ChangeCanvas(false);
                Destroy(GameController.instance.CurrentPuzzle);
            }
            else
            {
                electricty.UpdateTarget(nextPoint);
            }
        }
        else
        {
            Destroy(electricty.gameObject);
            print("Si no tiene el power necesario");
            //Si no tiene el power necesario
        }
    }
    public virtual void UpdateHud()
    {
        UpdateText("powerVariationtxt", ref powerVariationtxt, powerVariaton, "-", "");
        UpdateText("requiredPowertxt", ref requiredPowertxt, powerVariaton, "", "");
    }
    public void UpdateText(string textstr, ref Text text,int variable,string prefix,string sufijx)
    {
        text = transform.Find(textstr).GetComponent<Text>();
        if (text == null)
            return;

        text.text = "";
        if(variable != 0)
            text.text = prefix + variable.ToString() + sufijx;
    }
}
