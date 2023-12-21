using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    private GameObject[] platforms;
    private TMP_Text text;
    void Start()
    {
        for(int i = 0; i < platforms.Length; i+=2)
        {
            int randomNumber = UnityEngine.Random.Range(1, 3);
            if(randomNumber == 1)
            {
                platforms[i].GetComponent<BoxCollider>().isTrigger = true;
                platforms[i].GetComponent<DestroyPlatform>().enabled = true;
                platforms[i+1].GetComponent<BoxCollider>().isTrigger = false;
            }
            else
            {
                platforms[i].GetComponent<BoxCollider>().isTrigger = false;
                platforms[i + 1].GetComponent<BoxCollider>().isTrigger = true;
                platforms[i + 1].GetComponent<DestroyPlatform>().enabled = true;

            }
        }
        text = GameObject.Find("Lifes").GetComponent<TMP_Text>();
        text.text = "Lifes: " + GameObject.Find("Player").GetComponent<Movement>().lifes;
    }
}
