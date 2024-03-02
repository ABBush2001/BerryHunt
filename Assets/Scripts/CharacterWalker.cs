using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWalker : MonoBehaviour
{
    //this script moves with physics and old input. Arrows, joysticks or wasd
    //Needs collider and rigidbody 2D
    //make sure gravity scale is 0 if top down
    //make sure to free rotation on the z axis

    public Rigidbody2D theRB; //rigidbody on the object
    public float moveSpeed = 2f; //how fast we going

    //physics calculation should always be done in fixed update
    private void FixedUpdate()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

}
