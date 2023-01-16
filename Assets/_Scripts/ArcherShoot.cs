using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float Range;
    public GameObject Arrow;
    public GameObject Cam;
    
    void shoot() {
        RaycastHit hit;
        if(Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, Range)){
            Instantiate(Arrow, hit.point, transform.rotation);
        }
    }
}
