using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerUI : MonoBehaviour
{
    [SerializeField]
    private GameObject gameUI;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("MiniGame_1");
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameObject.Find("Pause").SetActive(false);
        gameUI.SetActive(true);
    }
}
