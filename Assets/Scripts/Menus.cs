using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Pause(GameObject pausePanel)
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void Resume(GameObject pausePanel)
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    public void FullScreenChange()
    {
        Screen.fullScreen =!Screen.fullScreen;
        print("ganti mode screen");
    }
}
