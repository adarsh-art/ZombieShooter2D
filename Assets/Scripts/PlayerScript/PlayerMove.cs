using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D myBody;
    public float moveForce_X = 1.5f, moveforce_Y = 1.5f;
    public PlayerAnimations playerAnimation;
    public float xMin, xMax, yMin, yMax;
    

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<PlayerAnimations>();
    }


    void FixedUpdate()
    {
        Move();
        transform.position = new Vector3
       (
           Mathf.Clamp(transform.position.x, xMin, xMax),
           Mathf.Clamp(transform.position.y, yMin, yMax),
           transform.position.z
       );

    }

    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (h > 0)
        {
            myBody.velocity = new Vector2(moveForce_X, myBody.velocity.y);
        }
        else if (h < 0)
        {
            myBody.velocity = new Vector2(-moveForce_X, myBody.velocity.y);
        }
        else
        {
            myBody.velocity = new Vector2(0f, myBody.velocity.y);
        }

        if (v > 0)
        {
            myBody.velocity = new Vector2(myBody.velocity.x, moveforce_Y);
        }
        else if (v < 0)
        {
            myBody.velocity = new Vector2(myBody.velocity.x, -moveforce_Y);
        }
        else
        {
            myBody.velocity = new Vector2(myBody.velocity.x, 0f);
        }

        //Animate
        if (myBody.velocity.x != 0 || myBody.velocity.y != 0)
        {
            playerAnimation.PlayerRunAnimation(true);
        }

        else if (myBody.velocity.x == 0 && myBody.velocity.y == 0)
        {
            playerAnimation.PlayerRunAnimation(false);
        }

        Vector3 tempScale = transform.localScale;
        if (h > 0)
        {
            tempScale.x = -1f;
        }
        else if (h < 0)
        {
            tempScale.x = 1f;
        }
        transform.localScale = tempScale;

        
    }
}
