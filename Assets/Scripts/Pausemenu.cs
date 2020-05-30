using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject crosshair;
    public Scene currentScene;

    string scenename;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        scenename = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        scenename = currentScene.name;

        //Debug.Log(scenename);
        
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
    }
    
    void Resume()
    {
     //   Cursor.visible = false;
     //   Cursor.lockState = CursorLockMode.Confined;
        pauseMenuUI.SetActive(false);
        // crosshair.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
      //  Cursor.visible = true;
     //   Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        // crosshair.SetActive(false);

        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void ResumeGame()
    {
        Resume();
    }
}
