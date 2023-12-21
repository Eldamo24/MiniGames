using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Restart : MonoBehaviour
{
    private Transform position;
    private TMP_Text text;

    private void Start()
    {
        position = GameObject.Find("RestartPosition").GetComponent<Transform>();
        text = GameObject.Find("Lifes").GetComponent<TMP_Text>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<Movement>().lifes -= 1;
            int lifes = GameObject.Find("Player").GetComponent<Movement>().lifes;
            other.transform.position = position.position;
            text.text = "Lifes: " + lifes;
        }
    }
}
