using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombieFollow : MonoBehaviour
{
    private float Mindist = 0.4f;
    public Transform Player;
    public float moveSpeed = 2f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private ZombieAnimation zombieAnimation;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        zombieAnimation = GetComponent<ZombieAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 direction = Player.position - transform.position;      
        direction.Normalize();
        movement = direction;
        if (rb.position.x > Player.position.x)
        {
           transform.localScale = new Vector2(1, 1);
        }
        else
        {
           transform.localScale = new Vector2(-1, 1);
        }
       
    }

    private void FixedUpdate() {
        moveCharacter(movement);
       
    }

    void moveCharacter(Vector2 direction) {
        
        if (Vector2.Distance(transform.position,Player.position)>=Mindist)
        { 
            rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime)); 
         }
       // rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
      
    }

    void anim() 
    {/*
        //Animation
        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            zombieAnimation.ZombieMoveAnimation(true);
        }

        else if (rb.velocity.x == 0 && rb.velocity.y == 0)
        {
            zombieAnimation.ZombieMoveAnimation(false);
        }
        */
    }

}
