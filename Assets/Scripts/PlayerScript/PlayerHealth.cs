using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public Transform bar;
    private Vector2 temp;
    public AudioSource hurt;
    public AudioSource Die;
    public ParticleSystem fxShot1;
    public ParticleSystem fxShot2;
    public GameObject gameOverUI;
    private PlayerAnimations playerAnimation;
    public float restartDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<PlayerAnimations>();
        gameOverUI.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            TakeDamage(0.05f);//0.05
            Debug.Log("Under Attack");
           
        }

        else if (other.gameObject.tag == "enemy2")
        {
            TakeDamage(0.07f);//0.07
            Debug.Log("Under Attack");

        }

        else if (other.gameObject.tag == "enemy3")
        {
            TakeDamage(0.1f);//0.09
            Debug.Log("Under Attack");

        }
        
        else if (other.gameObject.tag == "enemy4")
        {
            TakeDamage(0.23f);//0.1
            Debug.Log("Under Attack");

        }


    }
    void TakeDamage(float damage)
    {
        temp = bar.transform.localScale;
        if (temp.x > 0.05f)
        {
            
            temp.x -= damage;
            bar.transform.localScale = temp;
            playerAnimation.Hurt();
            fxShot1.Play();
            hurt.Play();

            if (temp.x < 0.05f)
            {
                temp.x = 0f;
                bar.transform.localScale = temp;
                playerAnimation.Dead();
                Die.Play();
                Debug.Log("Dead");
                fxShot2.Play();
                //Destroy(gameObject,0.5f);
                Invoke("Death", restartDelay);               
            }

        }
      
    }

    void Death()
    {       
        gameObject.SetActive(false);
    
    }
}
