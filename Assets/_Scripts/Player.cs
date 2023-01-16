using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 12f;
   

    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rigidbodyComponent;
    



    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
   
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

   


    //FixedUpade is called once every physics update  (it is reliable so it is in sync regardless of the frequency of the computer)
    private void FixedUpdate()
    {

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        rigidbodyComponent.AddForce(movement * speed);
       
        
    }
 
}
