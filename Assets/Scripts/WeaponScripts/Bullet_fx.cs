using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bullet_fx : MonoBehaviour
{
    public GameObject Player;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //flip bullet

        if (Player.transform.localScale.x < 0)
        {
            firePoint.transform.localScale = new Vector2(-1, 1);
        }

        else
        {
            firePoint.transform.localScale = new Vector2(1, 1);
        }

    }
}
