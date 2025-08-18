using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;   // for moving the player right and left 
    public float speed = 10.0f;     // speed for horizontal movement 
    public float xRange = 10;

    public GameObject projectilePrefab; // for the pizza **when assigning in Unity - be careful to asign it from the prefab not from 
                                        // the project 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
               
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); // horizontalInput manager is used to 
                                                                                           //get the input from the keys 

            // the below code is to set the boundary for the movement of the player
            if (transform.position.x < -xRange)// for not letting the player move/fall out of the play area from the "LEFT"
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
                /* whenever the position of the player goes -10, we are bringing it back to a new position determined 
                 by new vector3 x=-10 keeping it at -10, and retaining the y and z positions as they are not changing
                 current object's position - transform.position */
            }
            if (transform.position.x > xRange)// for not letting the player move/fall out of the play area from the "RIGHT"
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            horizontalInput = Input.GetAxis("Horizontal");
            //--------------------------------------------------------------------------

            // for the pizza projectile motion - we need input from the spacebar 
            if (Input.GetKeyDown(KeyCode.Space)) // keyCode - takes any key from the keyboard - here - Spacebar whenever it is pressed down
            {
                // launch a projectile from the player 
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                // instantiate - creating new/copy of objects already exist (here)
            }


        }
    }

