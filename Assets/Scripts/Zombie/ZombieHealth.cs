using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{   
    public Transform bar;
    public float zombie_lvl;
    private Vector2 temp;
    private ZombieAnimation zombieAnimation;
    public ParticleSystem fxShot1;
    public ParticleSystem fxShot2;
    public ParticleSystem exp;
    public ParticleSystem ground;
    public ParticleSystem fire;
    private int random_number;
    public AudioSource Die;
    public AudioSource hurt;
    public AudioSource blast;

   
    void Start()
    {
        ground.Play();
        zombieAnimation = GetComponent<ZombieAnimation>();
       
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "bat")
        {
            TakeDamage(0.1f);
            Debug.Log("Zombie Attack");

        }

        else if (other.gameObject.tag == "Pistol_bullet")
        {
            TakeDamage(0.2f);
            Debug.Log("Zombie Attack");

        }
        else if (other.gameObject.tag == "MP5_bullet")
        {
            TakeDamage(0.25f);
            Debug.Log("Zombie Attack");

        }
        else if (other.gameObject.tag == "M3_bullet")
        {
            TakeDamage(0.4f);
            Debug.Log("Zombie Attack");

        }
        else if (other.gameObject.tag == "AK_bullet")
        {
            TakeDamage(0.35f);
            Debug.Log("Zombie Attack");

        }
        else if (other.gameObject.tag == "Sniper_bullet")
        {
            TakeDamage(0.7f);
            Debug.Log("Zombie Attack");

        }
        else if (other.gameObject.tag == "RocketMissile")
        {
            TakeDamage(0.8f);
            Debug.Log("Zombie Attack");
            exp.Play();
            ground.Play();
            blast.Play();

        }


    }

    private void OnParticleCollision(GameObject other)
    {
        TakeDamage(0.75f);
        Debug.Log("Zombie Attack");
        if (other.gameObject.tag == "fire_flame")
        {
            TakeDamage(0.8f);
            Debug.Log("Zombie Attack");

        }

    }

    void TakeDamage(float damage)
    {
        temp = bar.transform.localScale;
        temp.x -= damage*zombie_lvl;
        bar.transform.localScale = temp;
        zombieAnimation.GetHurt();
        fxShot1.Play();
        hurt.Play();
        if (temp.x < 0.01f)
        {
            random_number = Random.Range(1, 4);           
            zombieAnimation.Dead(random_number);            
            Debug.Log("Dead");
            fxShot2.Play();
            Die.Play();
            Destroy(gameObject, 1f);
            temp.x = 0f;
            bar.transform.localScale = temp;
        }
        
    }
}
