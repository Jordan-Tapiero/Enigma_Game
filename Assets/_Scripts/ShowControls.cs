using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControls : MonoBehaviour
{
    public GameObject goToHide;

    public void DisplayControl()
    {
        bool currentState = goToHide.activeSelf;
        goToHide.SetActive(!currentState);
    }
}
