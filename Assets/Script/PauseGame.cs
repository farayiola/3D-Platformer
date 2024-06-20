using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour
{
    public bool gamePasused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pauseJingle;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {

            if (gamePasused == false)
            {
                pauseJingle.Play();
                Time.timeScale = 0;
                gamePasused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePasused = false;
                Time.timeScale = 1;
                
                
            }

        }
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePasused = false;
        Time.timeScale = 1;

    }
    public void RestartLevl()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePasused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);

    }
    public void QuitToMenu()
    {
        pauseMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePasused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
}