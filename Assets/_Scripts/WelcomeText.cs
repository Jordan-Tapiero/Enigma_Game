using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeText : MonoBehaviour
{
    public Text WhateverTextThingy;  //Add reference to UI Text here via the inspector
    private float timeToAppear = 5f;
    private float timeWhenDisappear=5f;

    //Call to enable the text, which also sets the timer
    public void EnableText()
    {
        WhateverTextThingy.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
    }

    //We check every frame if the timer has expired and the text should disappear
    void Update()
    {
        if (WhateverTextThingy.enabled && (Time.time >= timeWhenDisappear))
        {
            WhateverTextThingy.enabled = false;
        }
    }
}