using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    public GameObject Control;  //Add reference to UI Text here via the inspector
    private float timeToAppear = 8f;
    private float timeWhenDisappear = 8f;
    private bool timerTriggered = false;

    //Call to enable the text, which also sets the timer
    public void EnableText()
    {
        Control.SetActive(true);
        timeWhenDisappear = Time.time + timeToAppear;
    }

    //We check every frame if the timer has expired and the text should disappear
    void Update()
    {
        if (Control.activeSelf && (Time.time >= timeWhenDisappear) && !timerTriggered)
        {
            Control.SetActive(false);
            timerTriggered = true;
        }
    }
}