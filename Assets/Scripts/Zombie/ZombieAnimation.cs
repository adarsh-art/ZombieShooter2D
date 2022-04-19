using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimation : MonoBehaviour
{
    private Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    
    public void GetHurt()
    {
        anim.SetTrigger(TagManager.ZOMBIE_HURT_ANIMATION);
    }

    public void Dead(int random)
    {
        anim.SetInteger(TagManager.RANDOM_PARAMETER, random);
        anim.SetTrigger(TagManager.DEAD_PARAMETER);

    }
}
