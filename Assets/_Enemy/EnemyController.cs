using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
	#region Singleton

	public static EnemyController instance;

	private void Awake()
	{
		instance = this;
	}

	#endregion

	Animator animator;
	public float time = 20f;
	public GameObject player;

	public float lookRadius = 10f;

	Transform target;
	NavMeshAgent agent;
	//CharacterCombat combatManager;

	void Start()
	{
		target = EnemyController.instance.player.transform;
		agent = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();
		//combatManager = GetComponent<CharacterCombat>();
	}

	void Update()
	{
		// Get the distance to the player
		float distance = Vector3.Distance(target.position, transform.position);

		// If inside the radius
		if (distance <= lookRadius)
		{
			animator.SetBool("isWalking", true);

			// Move towards the player
			agent.SetDestination(target.position);
			if (distance <= agent.stoppingDistance)
			{
				// Attack
				//combatManager.Attack(EnemyController.instance.player.playerStats);
				FaceTarget();
				animator.SetBool("isWalking", false);
				animator.SetTrigger("Attack");
				/*time -= Time.deltaTime;
				if(time < 0){
                	Destroy(player);
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            	}*/
			}
		}
		else
        {
			animator.SetBool("isWalking", false);
		}
	}

	// Point towards the player
	void FaceTarget()
	{
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, lookRadius);
	}
	
}
