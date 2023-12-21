using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject panelGame;
    [SerializeField]
    private GameObject panelGameOver;
    void Update()
    {
        if(FindObjectOfType<Movement>().lifes == 0 || (int)FindObjectOfType<Timer>().seconds == 0)
        {
            panelGame.SetActive(false);
            panelGameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
