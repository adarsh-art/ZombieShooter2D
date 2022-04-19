using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDirection : MonoBehaviour
{
    public GameObject Player;
    public Transform HealthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.localScale.x < 1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
