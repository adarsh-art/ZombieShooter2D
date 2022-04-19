using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum NameWeapon { 
    MELEE,
    PISTOL,
    MP5,
    M3,
    AK,
    AWP,
    FIRE,
    ROCKET
}

public class WeaponController : MonoBehaviour
{
    public DefaultConfing defaultConfing;
    public NameWeapon nameWp;

    protected PlayerAnimations playerAnim;
    protected float lastShot;

    public int gunIndex;
    public int currentBullet;
    public int bulletMax;
    public Text count_bullet;
    public AudioSource emptyShot;
    public GameObject firepoint;

    void Awake()
    {
        playerAnim = GetComponentInParent<PlayerAnimations>();
        currentBullet = bulletMax;
    }

    public void CallAttack() {
        if (Time.time > lastShot + defaultConfing.fireRate)
        {
            if (currentBullet > 0)
            {
                firepoint.SetActive(true);
                ProcessAttack();

                //animation
                playerAnim.AttackAnimation();


                lastShot = Time.time;
                currentBullet--;               
                count_bullet.text = currentBullet.ToString();
            }
            else 
            {
                firepoint.SetActive(false);
                //Play No ammo sound
                emptyShot.Play();
            }
        }
        
    
    }

    public virtual void ProcessAttack() 
    {
        


    }
}
