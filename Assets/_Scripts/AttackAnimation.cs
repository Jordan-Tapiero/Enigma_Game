using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    Animator animator;
    public float attackCooldown = 1.0f;
    public bool attackReady = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && attackReady)
        {
            Attack1();
            attackReady = false;
            Invoke("ResetAttack",attackCooldown);
        }

        if (Input.GetMouseButtonDown(1) && attackReady)
        {
            Attack2();
            attackReady = false;
            Invoke("ResetAttack", attackCooldown);
        }
    }

    void Attack1()
    {
        animator.SetTrigger("Attack");
    }

    void Attack2()
    {
        animator.SetTrigger("Attack2");
    }

    void ResetAttack()
    {
        attackReady = true;
    }
}
