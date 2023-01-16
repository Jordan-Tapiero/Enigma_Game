using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherAttack : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //ADAM CONTINUE

        if (Input.GetMouseButtonDown(1))
        {
            print("Hello");
            animator.SetBool("aim", true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("shoot", true);
            animator.SetBool("aim", false);
        }
        else
        {
            animator.SetBool("shoot", false);
        }
    }
}
