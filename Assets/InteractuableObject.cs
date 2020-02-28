using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class InteractuableObject : MonoBehaviour
{
    GameObject descriptionText;
    GameObject pressKeyText;

    void Start()
    {
        pressKeyText = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.GetComponent<PlayerController>() != null)
        {
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

    public void ObjectInteraction()
    {
        pressKeyText.SetActive(false);
    }
}
