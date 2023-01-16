using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementArcher : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horiozntal");
        float y = Input.GetAxis("Vertocal");

        animator.SetFloat("Strafe", x);
        animator.SetFloat("Forward", y);
        
    }
}
