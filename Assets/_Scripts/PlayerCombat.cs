using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int swordDamage = 40;
    public int shieldDamage = 10;
    public Text ScoreText;
    public int Score;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Attack2();
        }
    }
    void Attack()
    {
        animator.SetTrigger("Attack");
       
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position,attackRange,enemyLayers);
        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHP>().TakeDamage(swordDamage);
        }

    }
    void Attack2()
    {
        animator.SetTrigger("Attack2");

        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyHP>().TakeDamage(shieldDamage);
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
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Diamonds"))
        {
            other.gameObject.SetActive(false);
            Score = Score + 200;
            addScore();
            
        }
    }
    void addScore(){
        
        ScoreText.text = Score.ToString();
    }
}
