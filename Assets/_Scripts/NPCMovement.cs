using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float moveSpeed;
    private bool isWalking;
    private Rigidbody myRigidbody;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;
    private int WalkDirection;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        waitCounter = waitTime;
        walkCounter = walkTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (isWalking)
        {
            walkCounter -= Time.deltaTime;
            switch (WalkDirection)
            {
                case 0:
                    myRigidbody.velocity = new Vector3(0, 0, moveSpeed);
                    break;
                case 1:
                    myRigidbody.velocity = new Vector3(moveSpeed, 0, 0);
                    break;
                case 2:
                    myRigidbody.velocity = new Vector3(-moveSpeed, 0, 0);
                    break;
                case 3:
                    myRigidbody.velocity = new Vector3(0, 0, -moveSpeed);
                    break;


            }

            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }
        }
        else
        {
            waitCounter -= Time.deltaTime;

            myRigidbody.velocity = Vector2.zero;

            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }


    public void ChooseDirection()
    {
        WalkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;

    }


}