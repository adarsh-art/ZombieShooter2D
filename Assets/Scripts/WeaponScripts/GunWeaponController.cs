using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWeaponController : WeaponController
{
    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public ParticleSystem fxShot;
    public AudioSource shot;

    private Collider2D fireCollider;
    private WaitForSeconds wait_Time = new WaitForSeconds(0.02f);
    private WaitForSeconds fire_ColliderWait = new WaitForSeconds(0.02f);

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public override void ProcessAttack() 
    {
        base.ProcessAttack();

        switch (nameWp) {

            case NameWeapon.PISTOL:
                bulletPrefab.SetActive(true);
                print("Fire from Pistol");
                fxShot.Play();
                shot.Play();
                break;

            case NameWeapon.MP5:
                fxShot.Play();
                shot.Play();
                bulletPrefab.SetActive(true);
                print("Fire from MP5");
                break;

            case NameWeapon.M3:
                fxShot.Play();
                shot.Play();
                bulletPrefab.SetActive(true);
                print("Fire from M3");
                break;

            case NameWeapon.AK:
                fxShot.Play();
                shot.Play();
                bulletPrefab.SetActive(true);
                print("Fire from AK47");
                break;

            case NameWeapon.AWP:
                fxShot.Play();
                shot.Play();
                bulletPrefab.SetActive(true);
                print("Fire from Sniper");
                break;

            case NameWeapon.FIRE:
                fxShot.Play();
                shot.Play();
                bulletPrefab.SetActive(false);
                print("Fire from Fire");
                break;

            case NameWeapon.ROCKET:
                fxShot.Play();
                shot.Play();
                bulletPrefab.SetActive(true);
                print("Fire from Rocket Launcher");
                break;


            /*default:
                bulletPrefab.SetActive(false);
                break;*/
        }
        
    }
    
    IEnumerator WaitForShootEffect() {
        yield return wait_Time;
        fxShot.Play();
        
    }
    
    IEnumerator ActiveFireCOllider() {
        fireCollider.enabled = true;       
        yield return fire_ColliderWait;       
        fireCollider.enabled = false;
    }

}
