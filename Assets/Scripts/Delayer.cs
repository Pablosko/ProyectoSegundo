using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delayer : Node
{
    public float delayTime;
    public float maxDelay = 20;
    public float currentTime;
    public Image timeImg;
    public Text timeTxt;
    Electricity ele;

    IEnumerator Timer()
    {
        while (true)
        {
            if (currentTime >= delayTime)
            {
                ele.stop = false;
                StopCoroutine(Timer());
            }
            else
            {
                currentTime += Time.deltaTime;
                timeImg.fillAmount = currentTime / delayTime;
            }
            yield return Time.deltaTime;
        }
    }
    void Start()
    {
        timeTxt.text = "" + delayTime;
    }

    void Update()
    {
       
    }
    public override void ComponentAction(Electricity electricty)
    {
        currentTime = 0;
        StartCoroutine(Timer());
        ele = electricty;
        electricty.stop = true;
        base.ComponentAction(electricty);
    }
    public void UpdateDelay(int add)
    {
        delayTime += add;
        if (delayTime >= maxDelay)
            delayTime = 0;

        timeTxt.text =""+ delayTime;
    }
}
