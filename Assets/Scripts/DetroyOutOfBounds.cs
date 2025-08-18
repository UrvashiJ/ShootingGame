using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this script deletes/detroys the food whenever it flies out of bound 
public class DetroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) // this is to detroy(remove) the pizza when it goes away - top bound 
        {
            Destroy(gameObject); // Destroy is used to delete the obejcts - here we have the gameObject itself to delete
        }
        else if (transform.position.z < lowerBound) // this is for the animals which are coming towards my side - lowerBound
        {
            Debug.Log("GameOver"); // debug is used to display the msg whenever a condition is met just 
            Destroy(gameObject);
        }


    }

}
