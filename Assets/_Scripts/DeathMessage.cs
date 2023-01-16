using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMessage : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!Player.activeSelf || Player == null)
        {
            this.gameObject.SetActive(true);
        }
    }
}
