using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
   private ParticleSystem blacksmoke;
  
    private Rigidbody2D missile;
    // Start is called before the first frame update
    void Start()
    {
       blacksmoke = GetComponent<ParticleSystem>();
      missile = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       missile.transform.position = blacksmoke.transform.position;      
       blacksmoke.Play();
    }

}
