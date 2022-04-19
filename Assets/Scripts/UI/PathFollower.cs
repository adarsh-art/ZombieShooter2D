using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    public Vector3 offset;
    public GameObject player;
    
    private Vector3 temp;
   public float xMin, xMax, yMin, yMax;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;


        transform.position = new Vector3
       (
           Mathf.Clamp(transform.position.x, xMin, xMax),
           Mathf.Clamp(transform.position.y, yMin, yMax),
           transform.position.z
       );


    }
}
