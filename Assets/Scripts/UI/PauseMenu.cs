using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausedMenuUI;
    public GameObject gameoverUI;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (player.activeSelf)
        {
            gameoverUI.SetActive(false);
        }
        else
        {
            gameoverUI.SetActive(true);
        }
    }

    public void Resume()
    {
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Restart()
    {
        player.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Pause()
    {
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu() 
    {
        Time.timeScale = 1f;
        Debug.Log("Loading Menu....");
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}
