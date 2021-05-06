using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     Rigidbody2D rb;
     float xInput;
     public float moveSpeed;
     Vector2 newPosition;// this variable can store 2 values--x and y;
                         //we have created vector2 cz in 2D if we want the position on the game we will want both x and y value.
                         //we cannot find positions with only one value.


    public float PositionLimit;



     private void Awake()
     {
         rb=GetComponent<Rigidbody2D>();
     }
     void Start()
     {

     }

     private void FixedUpdate()
     {
         MovePlayer(); 
     }
     void MovePlayer()
     {
         xInput= Input.GetAxis("Horizontal");//this always gives us value b/w -ve and +ve. When we are clicking left arrow key , it will give value
         // b/w 0 and -1 and for roght arrow key  will give value b/w 0 and 1.

         newPosition = transform.position;// we are storing current position of the player to the variable newPosition
         //we can get the current position of the player by tansform.position

         newPosition.x = newPosition.x + xInput * moveSpeed ;
         newPosition.x= Mathf.Clamp(newPosition.x, -PositionLimit, PositionLimit);

        //Mathf.Clamp clasmps the value b/w max float and min float value that is it restricted the value between max and min value .
        //arguments are as follows--> 'value that we want to restrict', 'min limit to which we want to restrict', 'max lomit to which we want to restrict'


         rb.MovePosition(newPosition);

     }
   


}
