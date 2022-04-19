using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public GameObject player;
    private Vector3 temp;
    public float yMin, yMax;

    // Start is called before the first frame update
    void Start()
    {
        temp = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + temp;
        transform.position = new Vector2
        (transform.position.x * 1.2f,
        Mathf.Clamp(transform.position.y, yMin, yMax)
        );
      //temp.x += player.transform.position.x;
      //temp.x -= -1;
      //transform.position=temp;
        /*temp = transform.position;
        temp.x +=  ;
        bar.transform.localScale = temp;
        temptransform.postion*/

    }
}
