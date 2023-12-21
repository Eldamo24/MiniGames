using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject panelGame;
    [SerializeField]
    private GameObject panelWin;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            panelGame.SetActive(false);
            panelWin.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
