using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_move : MonoBehaviour
{
   
    public float speed = 20f;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        moveFoward();
        Debug.Log("Bullet");
    }

   
    

    public void moveFoward()
    {

        rb.velocity = transform.right * speed * Time.deltaTime* 500;
        //transform.Translate(transform.right*speed);
    }

    
}
