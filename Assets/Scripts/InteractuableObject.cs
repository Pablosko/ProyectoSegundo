using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractuableObject : MonoBehaviour
{
    GameObject descriptionText;
    GameObject pressKeyText;
    public string MsgTxt = "Press E to Interact"; //default

    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.GetComponent<PlayerController>() != null)
        {
            pressKeyText = transform.GetChild(0).gameObject;
            pressKeyText.SetActive(true);
            pressKeyText.GetComponent<Text>().text = MsgTxt;
            GameController.instance.player.interaction = ObjectInteraction;
        }
    }
    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.GetComponent<PlayerController>() != null)
        {
            pressKeyText.SetActive(false);
        }
    }

    public virtual void ObjectInteraction()
    {
        pressKeyText.SetActive(false);
    }
}
