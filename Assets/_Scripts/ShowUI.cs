using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour {

    public Camera cam;
    public GameObject uiObject;
    public GameObject questBar;
    private ParticleSystem ps;

    void Start() 
    {
        uiObject.SetActive(false);
        questBar.SetActive(false);
        ps = this.GetComponentInChildren<ParticleSystem>();
    }    
    void OnTriggerEnter (Collider player) {
        if (player.gameObject.tag == "Player") {
            uiObject.SetActive(true);
            questBar.SetActive(true);
            StartCoroutine("WaitForSec");

            ps.Stop();
        }
        
    }

    IEnumerator WaitForSec() {
        yield return new WaitForSeconds(10);
        Destroy(uiObject);
        this.gameObject.SetActive(false);
    }
}
