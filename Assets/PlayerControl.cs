using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //create a referance to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;

    // start is called before the first frame update
    void Start()
    {
        //find the rigidbody2d component that is attached to the same object as this sctipt
        playerObject = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //create a 'float' that will be equal to the players horizontal input
        float movementValuex = Input.GetAxis("horizontal");

        // change the x velocity of the rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movementValuex, playerObject.velocity.y);
    }
}
