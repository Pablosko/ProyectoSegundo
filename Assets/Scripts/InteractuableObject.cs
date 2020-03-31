using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractuableObject : MonoBehaviour
{
    public bool interactuable;
    public bool autoInteractuable;
    Text pressKeyText;
    public string MsgTxt = "Press E to Interact"; //default
    public string lockMsgTxt = "Object locked"; //default

    void Start()
    {
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.GetComponent<PlayerController>() != null)
        {
            if (autoInteractuable)
            {
                ObjectInteraction();
            }
            else
            {

                pressKeyText = GameController.instance.messageTxt;
                pressKeyText.gameObject.SetActive(true);
                AssignText(pressKeyText);
                if(interactuable)
                GameController.instance.player.interaction = ObjectInteraction;
            }
        }
    }
    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.GetComponent<PlayerController>() != null)
        {
            pressKeyText = GameController.instance.messageTxt;
            pressKeyText.gameObject.SetActive(false);
        }
    }

    public virtual void ObjectInteraction()
    {
        pressKeyText = GameController.instance.messageTxt;
        pressKeyText.gameObject.SetActive(false);
    }
    public void AssignText(Text text)
    {
        if (interactuable)
        {
            pressKeyText.text = MsgTxt;
        }
        else
        {
            pressKeyText.text = lockMsgTxt;
        }
    }
}
