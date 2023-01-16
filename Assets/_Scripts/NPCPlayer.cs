using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPlayer : MonoBehaviour
{
    private GameObject triggeringNPC;
    private bool triggering;
    public GameObject npcText;


    // Update is called once per frame
    void Update()
    {
        if (triggering)
        {
            npcText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Hello my name is Jordan!");


            }
            else
            {
                npcText.SetActive(false);
            }
        }
        void onTriggerEnter(Collider other)
        {
            if (other.tag == "NPC")
            {
                triggering = true;
                triggeringNPC = other.gameObject;
            }
        }
        void onTriggerExit(Collider other)
        {
            if (other.tag == "NPC")
            {
                triggering = false;
                triggeringNPC = null;
            }
        }
    }
}