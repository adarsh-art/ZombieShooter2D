using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_bullet_move : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        moveFoward();
        Debug.Log("Bullet");
    }




    public void moveFoward()
    {

        rb.velocity = transform.right * speed * Time.deltaTime * 500;

    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

}
