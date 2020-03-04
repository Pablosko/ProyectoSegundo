using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuableObject : MonoBehaviour
{
    GameObject descriptionText;
    GameObject pressKeyText;

    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.GetComponent<PlayerController>() != null)
        {
            pressKeyText = transform.GetChild(0).gameObject;
            pressKeyText.SetActive(true);
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
