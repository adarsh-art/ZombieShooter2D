using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire_bullet : MonoBehaviour 
{ 
    public GameObject FirePoint;
    public GameObject bulletPistol;
    public GameObject bulletMP5;
    public GameObject bulletM3;
    public GameObject bulletAk;
    public GameObject bulletSniper;
    public GameObject bulletRocket;

    private float rateOfFire =0.1f;
    private GameObject current_Bullet;
    private WeaponManager weaponManager;
   
    private bool holding=false;
    private float holdDownTime;
    public Text text;

    void Awake()
    {
        weaponManager = GetComponent<WeaponManager>();
       // gunWeaponController = GetComponent<GunWeaponController>();
    }

    void Update()
    {
        
        
        //current_Type_Controls = weaponManager.current_Type_Control;
        if (FirePoint.activeSelf)
        {   
            if (weaponManager.current_Weapon_Index == 0)
            {               
                text.enabled = false;
            }

            else if (weaponManager.current_Weapon_Index == 1)
            {
                current_Bullet = bulletPistol;
                Shoot();
                text.enabled = true;
            }

            else if (weaponManager.current_Weapon_Index == 2)
            {
                current_Bullet = bulletMP5;
                Shoot2();
                text.enabled = true;
                
            }
            else if (weaponManager.current_Weapon_Index == 3)
            {
                current_Bullet = bulletM3;
                Shoot();

            }
            else if (weaponManager.current_Weapon_Index == 4)
            {
                current_Bullet = bulletAk;
                Shoot2();

            }
            else if (weaponManager.current_Weapon_Index == 5)
            {
                current_Bullet = bulletSniper;
                Shoot();

            }
            else if (weaponManager.current_Weapon_Index == 7)
            {
                current_Bullet = bulletRocket;
                Shoot();

            }
            /* if (current_Type_Controls == TypeControlAttack.Click)
             {
                 Shoot();
             }

             else if (current_Type_Controls == TypeControlAttack.Hold)
             {
                 if (Input.GetButtonDown("Fire1"))
                 {

                     holding = true;
                     //holdDownTime = Time.time;
                 }

                 else if (Input.GetButtonUp("Fire1"))
                 {

                     //holdDownTime = Time.time - holdDownTime;
                     holding = false;                   
                 }


                 if (holding)
                 {
                     holdDownTime -= Time.deltaTime;
                     if (holdDownTime <= 0)
                     {
                         holdDownTime = rateOfFire;
                         Shoot2();
                     }
                 }
                 else
                 {
                     holdDownTime -= Time.deltaTime;

                 }


             }*/
        }         
       
    }

    public void Shoot()
    {   
        if (Input.GetKeyDown(KeyCode.F))
        {
          
            GameObject spawn = Instantiate(current_Bullet , FirePoint.transform.position, FirePoint.transform.rotation);
            Destroy(spawn, 3);
           // print("Click");
        }       
    }

    public void Shoot2()
    {
        if (FirePoint.activeSelf)
        {
            if (Input.GetButtonDown("Fire1"))
            {

                holding = true;
                //holdDownTime = Time.time;
            }

            else if (Input.GetButtonUp("Fire1"))
            {

                //holdDownTime = Time.time - holdDownTime;
                holding = false;
            }


            if (holding)
            {
                holdDownTime -= Time.deltaTime;
                if (holdDownTime <= 0)
                {
                    holdDownTime = rateOfFire;
                    GameObject spawn = Instantiate(current_Bullet, FirePoint.transform.position, FirePoint.transform.rotation);
                    Destroy(spawn, 3f);
                    FirePoint.SetActive(false);
                    //print("Hold");
                }

            }
        }
        

    }
    

    
}
