using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    public GameObject player;
    public Text LvlStartUI; 
    public GameObject LvlCompleteUI;
    public float restartDelay = 1f;

    public void Awake()
    {       
        LvlStartUI.text = "Level " + SceneManager.GetActiveScene().buildIndex+ "\n REACH TILL SAFEZONE";
        LvlCompleteUI.SetActive(false);
    }

   

    //void Restart()
   // {
        //player.SetActive(true);
       // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            LvlCompleteUI.SetActive(true);
            Invoke("EndLvl",restartDelay);
        }
        
    }

    public void EndLvl()
    { 
            Debug.Log("Finished");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }

}