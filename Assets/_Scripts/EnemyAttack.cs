using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int swordDamage = 5;
    public GameObject Player;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        print(animator.GetCurrentAnimatorStateInfo(0));
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack")) {
        
            Attack();
            print("true");
        }
    }
    void Attack()
    { 

        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider enemy in hitEnemies)
        {
            enemy.GetComponent<PlayerHP>().TakeDamage(swordDamage);
        }

    }
    
   
    private void OnDrawGizmos()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
