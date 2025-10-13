using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
    public float moveSpeed; //how fast the character moves
public float jumpHeight; //how high the character jumps
//private bool IsFacingRight; //check if player is facing right
public KeyCode Spacebar; //Jump is the name we gave a keyboard button we chose to be the jump button.
// In this case, we chose the Space button, and called it Spacebar. To allocate the Space button to the name
// Spacebar, go to the Script
//component of your player character, and choose Space from the dropdown list
public KeyCode L;//L is the name we gave a keyboard button we chose to be the left movement button.
public KeyCode R;//R is the name we gave a keyboard button we chose to be the right movement button.
void Start () {
}
    // Start is called before the first frame update
   
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Spacebar)) //When user presses the space button ONCE
Jump();
//see function definition below
if (Input.GetKey(L)) //When user presses the left arrow button
GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the left along the x-axis without disrupting jump
if (Input.GetKey(R)) //When user presses the left arrow button
GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the right along the x-axis without disrupting jump
void Jump()
GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
//player character jumps vertically along the y-axis without disrupting horizontal walk
if (Input.GetKey (L)) //When user presses the left arrow button

GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the left along the x-axis without disrupting jump
if (GetComponent<SpriteRenderer>()!=null)
{
}
GetComponent<SpriteRenderer>().flipx = true;
if (Input.GetKey(R)) //When user presses the left arrow button

GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the right along the x-axis without disrupting jump
if (GetComponent<SpriteRenderer>()!=null)
{
GetComponent<SpriteRenderer>().flipx= false;

        
    }
}

    public class PlayerController: MonoBehaviour
public float moveSpeed; //how fast the character moves
public float jumpHeight; //how high the character jumps
//private bool IsFacingRight; //check if player is facing right
public KeyCode Spacebar; //Jump is the name we gave a keyboard button we chose to be the jump button.
// In this case, we chose the Space button, and called it Spacebar. To allocate the Space button to the name
// Spacebar, go to the Script
//component of your player character, and choose Space from the dropdown list
public KeyCode L;//L is the name we gave a keyboard button we chose to be the left movement button.
public KeyCode R;//R is the name we gave a keyboard button we chose to be the right movement button.
void Start () {
}
void Update ((
if (Input.GetKeyDown(Spacebar)) //When user presses the space button ONCE
Jump();
//see function definition below
if (Input.GetKey(L)) //When user presses the left arrow button
GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the left along the x-axis without disrupting jump
if (Input.GetKey(R)) //When user presses the left arrow button
GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the right along the x-axis without disrupting jump
void Jump()
GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
//player character jumps vertically along the y-axis without disrupting horizontal walk
if (Input.GetKey (L)) //When user presses the left arrow button

GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the left along the x-axis without disrupting jump
if (GetComponent<SpriteRenderer>()!=null)
{
}
GetComponent<SpriteRenderer>().flipx = true;
if (Input.GetKey(R)) //When user presses the left arrow button

GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the right along the x-axis without disrupting jump
if (GetComponent<SpriteRenderer>()!=null)
{
GetComponent<SpriteRenderer>().flipx= false;

}